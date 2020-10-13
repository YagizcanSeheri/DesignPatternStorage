using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Lab_2
{
    public class SingletonClass
    {
         
        //Constructor private yaparak bu sınıfın dışından instance alınmasını engelledik
        private SingletonClass()
        {

        }

        private static SingletonClass _tekNesne = new SingletonClass();
        //Oluşturduğumuz static nesnenin (_tekNesne) dışarıdan erişimini sağlamak için proporty tanımaldık.

        public static SingletonClass Sinif
        {
            get
            {
                return _tekNesne;
            }
        }

        public int Toplam(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
