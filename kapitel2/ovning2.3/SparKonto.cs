using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._3
{
    class SparKonto : BankKonto
    {
        public SparKonto(string personNummer, double ränteSats) : base(personNummer, ränteSats){}
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
            if (värde > base._behållning && värde > 0)
            {
                base._behållning -= värde;
                return true;
            }
            return false;
            
        }

        public override string ToString()
        {
            return "Sparkonto " + base._personNummer + ": " + base._behållning + "Kr";
        }
    }
}
