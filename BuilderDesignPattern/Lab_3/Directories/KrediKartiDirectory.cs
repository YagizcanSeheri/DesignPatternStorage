using BuilderDesignPattern.Lab_3.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_3.Directories
{
    public class KrediKartiDirectory
    {
        public void KartKullan(KrediKartiBuilder kart)
        {
            kart.BankaAdi();
            kart.KartTipi();
            kart.KartLimiti();
            kart.TaksitAtlama();
        }
    }
}
