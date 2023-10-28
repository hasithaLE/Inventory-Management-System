using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	internal class Product
	{
		public string productID { get; set; }
		public string productName { get; set; }
		public int productQty { get; set; }
		public double pricePerUnit { get; set; }

		public Product(string ID, String Name, int Qty, double Price) {
			this.productID = ID;
			this.productName = Name;
			this.productQty = Qty;
			this.pricePerUnit = Price;
		}
	}
}
