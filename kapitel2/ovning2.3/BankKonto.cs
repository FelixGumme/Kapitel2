using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._3
{
    abstract class BankKonto
    {
        protected string _personNummer;
        public double _behållning;
        protected double _ränteSats;
        public BankKonto(string personNummer, double ränteSats)
        {
            this._personNummer = personNummer;
            this._behållning = 0;
            this._ränteSats = ränteSats;
        }

        public abstract void SättaIn(double värde);
        public abstract bool TaUt(double värde);
        public abstract double RäknaUtRänta();
        public abstract override string ToString();
    }
}
