using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Lab_1
{

    public class SystemManager
    {
        private static SystemManager _systemManager; //field tanımladık

        public SystemManager()
        {
            //Amaç dış erişimi engelleme
        }

        //Bu methot vasıtasıyla singleton bir nesne yaratacağım
        public static SystemManager CreateSingleObject()
        {

            //Bu method içerisinde şunu kontrol edeceğiz, eğer system manager nesnesi daha önceden yaratılmışsa karar mekanizmasına girmeyerek direk yaratılmış nesneyi dönecek, yaratılmamışsa zaten "null" olacağı için if bloğundaki şart tutacak ve nesnemiz yaratılacak.
            if (_systemManager == null)
            {
                _systemManager = new SystemManager();
            }

            return _systemManager;
        }

        public void Add()
        {
            Console.WriteLine("An object was created..!");
            Console.ReadKey();
        }
    }
}

