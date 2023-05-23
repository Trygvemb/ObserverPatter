using System;
namespace Øvelse4
{
    public delegate void NotifyHandler();

    public class Academy : Organization, ISubject 
    {
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    Notify();
                }

            }
        }

        private NotifyHandler students;

        //private List<IObserver> observers = new List<IObserver>();


        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }

        public void Attach(IObserver o)
        {
            students += o.Update;
        }

        public void Detach(IObserver o)
        {
            students -= o.Update;
        }

        public void Notify()
        {
            students();
        }
    }
}

