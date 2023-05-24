using System;
namespace Øvelse4
{
	public interface INotifyMessageChanged
	{
        //public delegate void NotifyHandler( MessageChanged);
        //public delegate void EventHandler(object sender, EventArgs e);

        public event EventHandler MessageChanged;
    }
}

