using BuilderDesignPattern.Lab_3.Abstraction;
using BuilderDesignPattern.Lab_3.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_3.Concrete
{
    public class AMEXKartBuilder:KrediKartiBuilder
    {
        public AMEXKartBuilder()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Bank of America";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 10000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "American Express";
        }

        public override void TaksitAtlama()
        {
            kart.TaksitAlma = false;
        }
    }
}
