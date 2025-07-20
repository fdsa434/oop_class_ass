using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_class_ass.classes
{
    [Flags]
    enum permissions
    {
        add=1,
        delete=2,
        read=4,
        write=8
    }
    enum level:byte
    {
        guest=1,
        developer=4,
        DBA=2,
        secretary=5,
        security_office=3
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
        private permissions permission;
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
        public permissions Per
        {
            get
            {
                return permission;
            }
            set
            {
                if(securty_level== level.guest)
                {
                    permission = (permissions)permissions.read;

                }
                else if (securty_level == level.DBA)
                {
                    permission = (permissions)permissions.write;

                }
                else if (securty_level == level.security_office)
                {
                    permission = (permissions)15;
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
            get { return securty_level; }
            set
            {
                securty_level = value;
                switch (securty_level)
                {
                    case level.guest:
                        permission = permissions.read;
                        break;
                    case level.DBA:
                        permission = permissions.write;
                        break;
                    case level.developer:
                        permission = permissions.read | permissions.write;
                        break;
                    case level.secretary:
                        permission = permissions.read | permissions.add;
                        break;
                    case level.security_office:
                        permission = permissions.add | permissions.delete | permissions.read | permissions.write;
                        break;
                    default:
                        permission = 0;
                        break;
                }
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
            set {
                hire_date = value;
            }
        }

        public override string ToString()
        {
            return $"the salary of {id}the {securty_level}: {name} is {salary:c} on {hire_date} wih permissions {permission} ";
        }

    }
}
