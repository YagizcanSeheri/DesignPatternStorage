using AdapterDesignPattern.Lab_2.Abstraction;
using AdapterDesignPattern.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Uyarlayici birinciAdaptor = new Uyarlayici();
            //Console.WriteLine(birinciAdaptor.SpesifikIstek(5, 3));

            //IHedef ikinciadptor = new Adaptor();
            //Console.WriteLine(ikinciadptor.Istek(5));

            //Console.ReadKey();
            #endregion

            #region
            //Bagdastirici bagdastirici = new Bagdastirici();
            //ITarget target = new ConcreteAdapter(bagdastirici);

            //Console.WriteLine("Bağdaştırıcı arayüz istemci ile uyumsuz");
            //Console.WriteLine("Ancak concrete adaptör istemcisi bu yöntemi çağrabilir.");
            //Console.WriteLine(target.GetRequest());

            //Console.ReadKey();
            #endregion
        }
    }
}
