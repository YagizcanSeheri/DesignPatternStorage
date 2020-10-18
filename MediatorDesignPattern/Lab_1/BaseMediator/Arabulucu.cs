using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_1.BaseMediator
{
    public class Arabulucu
    {
        //Delegate oop açısından önemli bir konudur. Ek bilgi olarak delagate aynı anda kendisine atanmış methodları çalıştırmasından yada ilgili methodların yönetilmesinden sorumludur. Şöyle diyebiliriz üzerine atanmış method listesini bize döner.
        public delegate void GeriArama(string mesaj, string kimden);

        GeriArama yanıtlama; //Oluşturduğumuz delegate tipinde bir değişken tanımladık. Bunun nedeni delagate üzerine birazdan tanımlayacağımız methodları bu değişken vasıtasıyla delagate ekleyip çıakracağız.

        public void GirisYap(GeriArama method)
        {
            yanıtlama += method;
        }

        public void Engellenmis(GeriArama method)
        {
            yanıtlama -= method;
        }

        public void Engellenmemis(GeriArama method)
        {
            yanıtlama += method;
        }

        public void Gonder(string mesaj, string kimden)
        {
            yanıtlama(mesaj, kimden);
            Console.WriteLine();
        }
    }
}
