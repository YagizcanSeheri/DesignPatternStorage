using MediatorDesignPattern.Lab_3.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_3.Concrete
{
    public class Student : AssignedCourseMember
    {
        public Student(CoreMediator coreMediator) : base(coreMediator)
        {

        }

        public string Name { get; set; }

        public void SendQuestion(string message)
        {
            Console.WriteLine("Student send question {0}", message);
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("Student received answer {0}", answer);
        }
    }
}
