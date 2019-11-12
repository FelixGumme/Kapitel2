using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._2
{
    class OfficeWorker : Employee
    {
        private double _monthlySalary;

        public OfficeWorker(string name, double monthlySalary) : base(name)
        {
            this._name = name;
            this._monthlySalary = monthlySalary;
        }

        //ToString
        public override string ToString()
        {
            return _name + " (Kontorist)";
        }

        //CalculateSalary
        public override double CalculateSalary()
        {
            return _monthlySalary;
        }
    }
}
