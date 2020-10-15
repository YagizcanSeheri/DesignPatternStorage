using AdapterDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concrete
{
    public class Adaptor : Uyarlayici, IHedef
    {
        public string Istek(int i)
        {
            return "Yaklaşık tahmin: " + (int)Math.Round(SpesifikIstek(i, 3));
        }
    }
}
