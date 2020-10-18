using MediatorDesignPattern.Lab_1.BaseColleague;
using MediatorDesignPattern.Lab_1.BaseMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_1.Colleauge
{
    public class Collegue_A : MainColluague
    {
        public Collegue_A(Arabulucu mediator, string isim) : base(mediator, isim)
        {

        }

        public override void TeslimAlma(string mesaj, string kimden)
        {
            if (!String.Equals(kimden, _isim))
            {
                Console.WriteLine(_isim + " alındı " + kimden + " : " + mesaj);
            }
        }
    }
}
