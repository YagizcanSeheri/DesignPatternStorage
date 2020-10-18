using MediatorDesignPattern.Lab_3.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_3
{
    public class CoreMediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> student { get; set; }

        public void SendQuestion(string question, Student student)
        {
            Teacher.ReceiveQustion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }
}
