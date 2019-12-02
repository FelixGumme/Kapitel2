using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._3
{
    class LåneKonto : BankKonto
    {
        double _kredit;
        public LåneKonto(string personNummer, double ränteSats, double kredit) : base(personNummer, ränteSats) { }

        public override double RäknaUtRänta()
        {
            return base._behållning * ((base._ränteSats / 100) + 1);
        }

        public override void SättaIn(double värde)
        {
            base._behållning += värde;
        }

        public override bool TaUt(double värde)
        {
            if((base._behållning - _kredit) < (base._behållning - värde))
            {
                base._behållning -= (värde - _kredit);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Lånekonto " + base._personNummer + ": " + base._behållning + "Kr";
        }
    }
}
