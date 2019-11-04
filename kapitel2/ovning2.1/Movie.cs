using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2._1
{
    class Movie : Sound
    {
        string _resolution;

        public Movie(string resolution, int playtime, string title) : base(playtime, title)
        {
            this._resolution = resolution;
        }

        public override string ToString()
        {
            return _title + ": " + _playTime + " minuter " + _resolution;
        }
    }
}
