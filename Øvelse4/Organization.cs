using System;
namespace Øvelse4
{
	public class Organization
	{
		private string name;
		private string address;

		public string Name
		{
			get { return name; }
		}
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public Organization(string name)
		{
			this.name = name;
			
		}
	}
}

