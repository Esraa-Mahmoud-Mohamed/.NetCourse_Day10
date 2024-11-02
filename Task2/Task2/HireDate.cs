using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class HireDate:IComparable
    {
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate()
        {
            Day = default;
            Month = default;
            Year = default;
        }
        public HireDate(int _day, int _month, int _year)
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public int CompareTo(object obj)
        {
            HireDate hireDate = (HireDate)obj;
            return Year.CompareTo(hireDate.Year);
        }
    }
}
