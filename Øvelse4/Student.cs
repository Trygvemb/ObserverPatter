using System;
using System.Xml.Linq;

namespace Øvelse4
{
    public class Student : Person, IObserver
    {


        public Student(string name) : base(name)
        {
        }

        public void Update(object sender, EventArgs e)
        {
            if (sender is Academy academy)
            {
                Console.WriteLine($"Studerende {base.Name} modtog nyheden '{academy.Message}' fra akademiet {academy.Name}");

            }

        }
    }
}

