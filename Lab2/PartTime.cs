using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PartTime : Employee
    {
        double rate;
        double hours;

        public double Rate { get => rate; set => rate = value; }
        public double Hours { get => hours; set => hours = value; }

        public PartTime() { }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;
        }
        public double GetPay()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
