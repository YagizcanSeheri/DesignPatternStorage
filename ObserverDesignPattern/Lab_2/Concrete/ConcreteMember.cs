using ObserverDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Lab_2.Concrete
{
    public class ConcreteMember : IMember
    {
        public string Email { get; set; }

        public void Update(Product product)
        {
            Console.WriteLine("{0}'in fiyatı {1} oldu. Bilgilendirme {2} adresini gönderildi..!", product.ProductName, product.Price, Email);
        }
    }
}
