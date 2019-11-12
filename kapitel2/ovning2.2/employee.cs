using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._2
{
    class Employee
    {
        protected string _name;

        public Employee(string name)
        {
            this._name = name;
        }

        // ToString metod
        public override string ToString()
        {
            return _name;
        }

        // CalculateSalary metod
        public virtual double CalculateSalary()
        {
            return 0d;
        }
    }
}
