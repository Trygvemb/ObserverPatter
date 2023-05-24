using System;
using System.ComponentModel;

namespace Øvelse4
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class Academy : Organization, INotifyPropertyChanged
    {
        private string message;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged("Message");
                }

            }
        }

        //public event EventHandler MessageChanged;

        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }


        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

