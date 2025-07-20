using oop_class_ass.classes;

namespace oop_class_ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            employee[] employees = new employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"\n--- Enter data for Employee #{i + 1} ---");

                string name;
                do
                {
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(name));

                double salary;
                do
                {
                    Console.Write("Enter Salary (Max 25000): ");
                } while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0);

                byte genderChoice;
                do
                {
                    Console.WriteLine("Choose Gender:");
                    Console.WriteLine("0 - Male");
                    Console.WriteLine("1 - Female");
                } while (!byte.TryParse(Console.ReadLine(), out genderChoice) || (genderChoice != 0 && genderChoice != 1));
                gender gen = (gender)genderChoice;

                byte levelChoice;
                do
                {
                    Console.WriteLine("Choose Security Level:");
                    Console.WriteLine("1 - guest");
                    Console.WriteLine("2 - DBA");
                    Console.WriteLine("3 - Security office");
                    Console.Write("Your Choice: ");
                } while (!byte.TryParse(Console.ReadLine(), out levelChoice) || levelChoice < 1 || levelChoice > 3);
                level lvl = (level)levelChoice;

                int day;
                do
                {
                    Console.Write("Enter Day (1-31): ");
                } while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31);

                int month;
                do
                {
                    Console.Write("Enter Month (1-12): ");
                } while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);

                int year;
                do
                {
                    Console.Write($"Enter Year (1900 - {DateTime.Now.Year}): ");
                } while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year);

                HiringDate hireDate = new HiringDate { Day = day, Month = month, Year = year };

                employee emp = new employee();
                permissions p;
                emp.Name = name;
                emp.Salary = salary;
                emp.Gender = gen;
                emp.Securty_level = lvl;
                emp.Hire_date = hireDate;
            
              

                    employees[i] = emp;
            }
            //4
            Console.WriteLine("\n \n All Employees \n \n ---");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion

        }
    }
}
