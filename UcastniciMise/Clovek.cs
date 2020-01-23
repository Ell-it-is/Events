using System;
using System.Collections.Generic;
using System.Text;

namespace UcastniciMise
{
    public abstract class Clovek
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Říkejte mi: {Name}";
        }
    }
}
