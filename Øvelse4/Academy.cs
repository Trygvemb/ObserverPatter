using System;
namespace Øvelse4
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class Academy : Organization, INotifyMessageChanged
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
                    OnMessageChanged();
                }

            }
        }

        public event EventHandler MessageChanged;


        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }



        event EventHandler INotifyMessageChanged.MessageChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void OnMessageChanged()
        {
            MessageChanged(this, EventArgs.Empty);
        }

    }
}

