using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab_1
            //Handler start = null;

            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"Handler {i} deals up a limit of {i * 1000}");
            //    start = new Handler(i, start);
            //}

            //int[] request = { 20000, 1000, 1500, 45000, 5000 };

            //foreach (var item in request)
            //{
            //    Console.WriteLine(start.HandlerRequest(item));
            //}

            //Console.ReadKey();
            #endregion

            #region Lab_2
            ////Zincirin halkalarını tanımlayalım
            //PlayerHandler aviPlayer = new HandlerAvi();
            //PlayerHandler mp3Player = new HandlerMp3();
            //PlayerHandler mp4Player = new HandlerMp4();

            ////Zincirin halkalarını sıralıyoruz
            //// İstek hangi sıra ile Handler sınıflarına iletileceğini belirtiyoruz
            //mp3Player.NextHandler = mp4Player;
            //mp4Player.NextHandler = aviPlayer;

            ////İstek zincirinin ilk halkasını göneriyoruz
            //mp3Player.Player("video.mpg");
            //mp3Player.Player("video.avi");
            //mp3Player.Player("video.mp4");
            //mp3Player.Player("video.swf");

            //Console.ReadKey();
            #endregion

            #region Lab_3
            //Manager manager = new Manager();
            //VicePresident vicePresident = new VicePresident();
            //President president = new President();

            //manager.SetSuccessor(vicePresident);
            //vicePresident.SetSuccessor(president);

            //Expense expense = new Expense { Amount = 1500, Detail = "Course" };

            //manager.HandleExpense(expense);

            //Console.ReadKey();
            #endregion
        }
    }
}
