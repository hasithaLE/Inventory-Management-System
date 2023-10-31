using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	internal class Inventory
	{
		public Product Product { get; set; }
		public Inventory(Product product) 
		{
			this.Product = product;
		}
		public static void addProduct(Inventory inventory)
		{
			//productList.Add(pList);
		}
	}
}
