using BuilderDesignPattern.Lab_3.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_3.Abstraction
{
    public abstract class KrediKartiBuilder
    {
        protected KrediKarti kart;

        public KrediKarti Kart
        {
            get { return kart; }
        }

        public abstract void BankaAdi();
        public abstract void KartTipi();
        public abstract void KartLimiti();
        public abstract void TaksitAtlama();
    }
}
