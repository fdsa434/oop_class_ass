using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_class_ass.classes
{
    class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    throw new ArgumentException("Day must be between 1 and 31.");
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentException("Month must be between 1 and 12.");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    year = value;
                else
                    throw new ArgumentException($"Year must be between 1900 and {DateTime.Now.Year}.");
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
