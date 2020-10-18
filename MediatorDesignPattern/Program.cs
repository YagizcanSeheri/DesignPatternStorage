using MediatorDesignPattern.Lab_3;
using MediatorDesignPattern.Lab_3.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            //Arabulucu arabulucu = new Arabulucu();

            //MainColluague merkez_1 = new MainColluague(arabulucu, "Yagizcan Seheri");
            //Collegue_A sube_1 = new Collegue_A(arabulucu, "Berk Seheri");
            //MainColluague merkez_2 = new MainColluague(arabulucu, "Can Seheri");

            //merkez_1.Gonder("Çarşamba günü için bir toplantı düzenledim, lütfen mailleriniz üzerinden onaylar mısınız?");
            //sube_1.Gonder("Tamamdır onaylıyorum iyi çalışmalar");
            //arabulucu.Engellenmemis(sube_1.TeslimAlma);
            //merkez_1.Gonder("Toplantı için hala eksiklikler bulunmaktadır..!");
            //merkez_2.Gonder("Eksikler tamamlandı");
            //arabulucu.Engellenmemis(sube_1.TeslimAlma);
            //merkez_1.Gonder("Hepinize teşekür ederim..!");

            //Console.ReadKey();
            #endregion

            #region Lab_2
            //IChatMediator chatMediator = new ChatMediator();
            //IUser yagizcan = new BasicUser(chatMediator, "Yagizcan");
            //IUser berk = new PremiumUser(chatMediator, "Berk");
            //IUser yagiz = new PremiumUser(chatMediator, "Yagiz");

            //chatMediator.AddUser(yagizcan);
            //chatMediator.AddUser(berk);
            //chatMediator.AddUser(yagiz);

            //yagiz.SendMessage("Selam Arkadaslar!");

            //Console.ReadKey();
            #endregion

            #region Lab_3
            //CoreMediator mediator = new CoreMediator();

            //Teacher teacher = new Teacher(mediator);
            //teacher.Name = "Yagiz";

            //Student student = new Student(mediator);
            //student.Name = "Tembel berk";


            //Student student_1 = new Student(mediator);
            //student.Name = "Tembel yagizcan";

            //mediator.student = new List<Student> { student, student_1 };

            //student.SendQuestion("Soru");
            //teacher.AnswerQuestion("Cevap", student);

            //Console.WriteLine("====================");
            //teacher.ReceiveQustion("pişt", student_1);
            //teacher.AnswerQuestion("hoop", student_1);

            //Console.ReadKey();
            #endregion
        }
    }
}
