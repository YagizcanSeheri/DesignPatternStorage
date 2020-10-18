using BuilderDesignPattern.Lab_3.Abstraction;
using BuilderDesignPattern.Lab_3.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_3.Concrete
{
    public class VisaKartBuilder:KrediKartiBuilder
    {
        public VisaKartBuilder()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 10000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Visa";
        }

        public override void TaksitAtlama()
        {
            kart.TaksitAlma = true;
        }
    }
}
