using System;
namespace Øvelse4
{
    public class Academy : Organization, ISubject 
    {
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }

        //private List<IObserver> observers = new List<IObserver>();

        public delegate void NotifyHandler();

        private NotifyHandler students;
        

        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }

        public void Attach(IObserver o)
        {
            students.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}

