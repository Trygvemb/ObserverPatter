using System;
using System.Xml.Linq;

namespace Øvelse4
{
    public class Student : Person, IObserver
    {
        private Academy academy;
        //private readonly string name;

        public string Message { get; set; }
        //public string Name
        //{
        //    get { return name; }
        //}
        //public Student(Academy subject, string name)
        //{
        //    this.subject = subject;
        //    this.name = name;
        //    this.subject.Attach(this);
        //}

        //public override void Update()
        //{
        //    Console.WriteLine($"Studerende {name} modtog nyheden '{subject.Message}' fra akademiet {subject.Name}");
        //}
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

