using System;
namespace Ex31_ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private int state = 0;

        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }
    }
}

