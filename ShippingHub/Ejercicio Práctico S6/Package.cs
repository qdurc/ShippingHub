using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Práctico_S6
{
	internal class Package
	{
		private int packageID;
		private string address;
		private string city;
		private int zip;
		private string state;

		public int PackageID
		{
			get
			{
				return packageID;
			}
		}
		public string Address
		{
			get 
			{ 
				return address;
			}
			set
			{
				address = value;
			}
		}
		public string City
		{
			get
			{
				return city;
			}
			set
			{
				city = value;
			}
		}
		public int Zip
		{
			get 
			{
				return zip;
			}
			set
			{
				if (value.ToString().Length == 5) 
				{
					zip = value;
				}
				else
				{
					zip = 0;
				}
			}
		}
		public string State
		{
			get 
			{
				return state;
			}
			set 
			{ 
				state = value; 
			}
		}

		public Package(int packageID, string address, string city, int zip, string state)
		{
			this.packageID = packageID;
			this.address = address;
			this.city = city;
			this.zip = zip;
			this.state = state;
		}
	}
}
