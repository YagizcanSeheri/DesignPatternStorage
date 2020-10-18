using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_3.Delegate
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public int KartLimiti { get; set; }
        public bool TaksitAlma { get; set; }

        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müsteri {KartTipi}'ni kullanmakta ve kartının {KartLimiti} limiti sahiptir. Ayrıca taksit alma seçeneği ise: {TaksitAlma}";
        }
    }
}
