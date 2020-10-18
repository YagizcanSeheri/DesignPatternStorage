using MediatorDesignPattern.Lab_3.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_3.Concrete
{
    public class Teacher : AssignedCourseMember
    {
        public Teacher(CoreMediator coreMediator) : base(coreMediator)
        {

        }

        public string Name { get; set; }

        public void ReceiveQustion(string question, Student student)
        {
            Console.WriteLine("Teacher receive a question from {0}, {1}", student.Name, question);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher answer question {0},{1}", student.Name, answer);
        }
    }
}
