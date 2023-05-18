using System;
namespace Øvelse4
{
    public class Academy : Subject
    {
        private string message;
        private string name;

        public string Name
        {
            get { return name; }
        }

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }

        public Academy(string name)
        {
            this.name = name;
        }
    }
}

