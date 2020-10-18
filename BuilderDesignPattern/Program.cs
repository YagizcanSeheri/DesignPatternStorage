using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            //Directory directory = new Directory();
            //IBuilder b_1 = new Builder_1();
            //IBuilder b_2 = new Builder_2();

            //directory.Constructor(b_1);
            //Product p_1 = b_1.GetResult();
            //p_1.Display();

            //directory.Constructor(b_2);
            //Product p_2 = b_2.GetResult();
            //p_2.Display();

            //Console.ReadKey();
            #endregion

            #region Lab_2
            //ProductDirectory directory = new ProductDirectory();
            //ProductBuilder builder = new A_ProductBuilder();

            //directory.GenerateProduct(builder);

            //var model = builder.GetModel();

            //Console.WriteLine(model.Id);
            //Console.WriteLine(model.ProductName);
            //Console.WriteLine(model.UnitPrice);
            //Console.WriteLine(model.DiscountPrice);
            //Console.WriteLine(model.DiscountedApplied);

            //Console.ReadKey();
            #endregion

            #region Lab_3
            //KrediKartıBuilder gercekKart = new AmericanExpressKartBuilder();
            //KrediKartDictory kullan = new KrediKartDictory();
            //kullan.KartKullan(gercekKart);

            //Console.WriteLine(gercekKart.Kart.ToString());

            //Console.ReadKey();
            #endregion

        }

    }
    
}
