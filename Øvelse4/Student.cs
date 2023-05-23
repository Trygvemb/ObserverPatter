using System;
using System.Xml.Linq;

namespace Øvelse4
{
    public class Student : Person, IObserver
    {
        private Academy academy;

        public string Message { get; set; }

        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
            this.Message = academy.Message;
        }

        public void Update()
        {


            Console.WriteLine($"Studerende {base.Name} modtog nyheden '{academy.Message}' fra akademiet {academy.Name}");
        }
    }
}

