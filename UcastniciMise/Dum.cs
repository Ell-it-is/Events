using System;
using System.Collections.Generic;
using System.Text;

namespace UcastniciMise
{
    public abstract class Dum
    {
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"Dům se nachází na adrese: {Adress}";
        }
    }
}
