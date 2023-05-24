using System;
namespace Øvelse4
{
    public delegate void NotifyHandler();

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
                    MessageChanged();
                }

            }
        }

        public NotifyHandler MessageChanged;


        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }

        event NotifyHandler INotifyMessageChanged.MessageChanged
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
            MessageChanged();
        }

    }
}

