using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._1
{
    class Book : Media
    {
        int _pageAmount;
        public Book(int pageAmount, string title) : base(title)
        {
            this._pageAmount = pageAmount;
        }

        public override string ToString()
        {
            return _title + ": " + _pageAmount + " sidor";
        }
    }
}
