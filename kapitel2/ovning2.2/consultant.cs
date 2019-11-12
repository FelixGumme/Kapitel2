using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._2
{
    class Consultant : Employee
    {
        private double _hourlySalary;
        private double _timeWorked;

        public Consultant(string name, double hourlySalary, double timeWorked) : base(name)
        {
            this._name = name;
            this._hourlySalary = hourlySalary;
            this._timeWorked = timeWorked;
        }

        //ToString
        public override string ToString()
        {
            return _name + " (Konsult)";
        }

        // CalculateSalary metod
        public override double CalculateSalary()
        {
            return (_hourlySalary * _timeWorked);
        }
    }
}
