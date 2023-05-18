using System;
namespace Øvelse4
{
    public class Student : Observer
    {
        private Academy subject;
        private readonly string name;

        public string Message { get; set; }
        public string Name
        {
            get { return name; }
        }
        public Student(Academy subject, string name)
        {
            this.subject = subject;
            this.name = name;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Studerende {name} modtog nyheden '{subject.Message}' fra akademiet {subject.Name}");
        }
    }
}

