using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._3
{
    class LåneKonto : BankKonto
    {
        public LåneKonto(string personNummer, double ränteSats) : base(personNummer, ränteSats) { }

        public override double RäknaUtRänta()
        {
            throw new NotImplementedException();
        }

        public override void SättaIn(double värde)
        {
            throw new NotImplementedException();
        }

        public override bool TaUt(double värde)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
