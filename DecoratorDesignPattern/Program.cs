using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            //IBilesen bilesen = new Bilesen();

            //Client.Display("1.Basit Bileşen: ",bilesen);
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");
            //Client.Display("2.Bileşene A-Dekaratörü Eklendi: ", new Decorator_A(bilesen));
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");
            //Client.Display("3.Bileşene B-Dekaratörü Eklendi: ", new Decorator_B(bilesen));
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");
            //Client.Display("4.Bileşenene İlk Önce A-Dekaratörü sonra B-Dekaratörü Eklendi", new Decorator_B(new Decorator_A(bilesen)));
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            //Decorator_B decorator_B = new Decorator_B(new Bilesen());
            //Client.Display("5.Bileşene ilk önce B-Dekaratörü daha sonra B-Decaratörü eklendi:  ", new Decorator_B(decorator_B));
            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            //Console.WriteLine("\t\t\t" + decorator_B.EklenenDavranis());

            //Console.ReadKey();

            #endregion
            #region Lab_2
            //var myCar = new SUV { Make = "Mercedes", Model = "2019 XC180", HirePrice = 3800 };

            //HireOffer hireOffer = new HireOffer(myCar);
            //hireOffer.DiscountPercentage = 10;

            //Console.WriteLine("First Hire Price: {0}", myCar.HirePrice);
            //Console.WriteLine("Discount Applied: {0}", hireOffer.HirePrice);

            //Console.ReadKey();
            #endregion
        }
    }
}
