using System;
namespace Ex31_ObserverPattern
{
	public class ConcreteObserver : Observer
	{
		private ConcreteSubject subject;

		public int State { get; set; } = 0;

		public override void Update()
		{
			State = subject.State;
			
		}
		public ConcreteObserver(ConcreteSubject subject)
		{
			this.subject = subject;
            this.subject.Attach(this);
			this.subject.Detach(this);

        }

	}
}

