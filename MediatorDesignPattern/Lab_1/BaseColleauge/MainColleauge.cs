using MediatorDesignPattern.Lab_1.BaseMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_1.BaseColleague
{
    public class MainColluague
    {
        Arabulucu _mediator;

        protected string _isim;

        public MainColluague(Arabulucu mediator, string isim)
        {
            this._mediator = mediator;
            _mediator.GirisYap(TeslimAlma);
            this._isim = isim;

        }

        public virtual void TeslimAlma(string mesaj, string kimden)
        {
            Console.WriteLine("Gönder: " + _isim + "\nMesaj: " + mesaj);
        }

        public void Gonder(string mesaj)
        {
            Console.WriteLine("Gönderen: " + _isim + "\nMesaj: " + mesaj);
        }
    }
}
