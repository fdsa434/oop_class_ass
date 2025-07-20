using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_class_ass.classes
{
    enum level:byte
    {
        guest,
        developer,
        DBA,
        secretary
    }
    enum gender:byte
    {
       male,
       female
    }
    class employee
    {
        private static int nextId = 1;
        private int id;
        private double salary;
        private string name;
        private level securty_level;
        private gender gender;
        private HiringDate hire_date;

        public employee()
        {
            id = nextId;
            nextId++;
        }
        public int Id
        {
            get { return id; }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value <= 25000)
                {
                    salary = value;
                }
                else
                {
                    salary = 25000;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
      public level Securty_level
        {
            get
            {
                return securty_level;
            }
            set
            {
                securty_level = value;
            }
        }
        public gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public HiringDate Hire_date
        {
            get { return hire_date; }
            set { hire_date = value; }
        }

        public override string ToString()
        {
            return $"the salary of {id}the {securty_level}: {name} is {salary:c} on {hire_date}";
        }

    }
}
