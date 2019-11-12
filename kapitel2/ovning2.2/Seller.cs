using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._2
{
    class Seller : Employee
    {
        double _provision;
        double _sellerSale;

        public Seller(string name, double provision, double sellerSale) : base(name)
        {
            this._name = name;
            this._provision = provision;
            this._sellerSale = sellerSale;
        }

        public override string ToString()
        {
            return _name + " (Säljare)";
        }

        // CalculateSalary metod
        public override double CalculateSalary()
        {
            return (_sellerSale * (_provision / 100));
        }
    }
}
