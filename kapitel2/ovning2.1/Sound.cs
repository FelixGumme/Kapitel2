using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._1
{
    class Sound : Media
    {
        protected double _playTime;

        public Sound(double playTime, string title) : base(title)
        {
            this._playTime = playTime;
        }

        public override string ToString()
        {
            return _title + ": " + _playTime + " minuter";
        }
    }
}
