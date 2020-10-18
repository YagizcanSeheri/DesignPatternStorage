using ChainOfResponsibilityDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern.Lab_2.Concrete
{
    public class HandlerMp4 : PlayerHandler
    {
        public override void Player(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor (mp4 player)...", filePath);
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(filePath);
                }
            }
        }
    }
}
