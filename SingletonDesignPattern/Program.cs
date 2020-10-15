using SingletonDesignPattern.Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not: Lab uygulamalarımızda  sınıfı, sınıf dışında new anahtar sözcüğü vasıtasıyla oluşturamayız. Çünkü constructor private yaptık ve singleton deseni mantığına ters düşmedik.

            #region
            //var systemManager = SystemManager.CreateSingleObject();
            //systemManager.Add();
            #endregion

            #region
            //int toplma_1 = SingletonClass.Sinif.Toplam(1, 2);
            //Console.WriteLine(toplma_1);
            //Console.ReadKey();
            #endregion


        }
    }
}
