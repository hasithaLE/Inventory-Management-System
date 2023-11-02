using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	internal class Inventory
	{
		static List<Product> productList = new List<Product>();
		public static void addProduct()
		{
			Console.Write("Enter Product ID: ");
			string productID = Console.ReadLine();
			Console.Write("Enter Product Name: ");
			string productName = Console.ReadLine();
			Console.Write("Enter Quantity: ");
			int productQty = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Price per unit: ");
			double productPricePU = Convert.ToDouble(Console.ReadLine());

			var product = new Product(productID, productName, productQty, productPricePU);
			productList.Add(product);
			Console.WriteLine("New Product Added\n");
			Console.WriteLine($"Product ID: {product.productID}\nProduct Name: {product.productName}\nQty: {product.productQty}\nPrice: {product.pricePerUnit}\n");
		}
		public static void deleteProduct() 
		{
			Console.Write("Enter Product ID you want to delete: ");
			string deleteID = Console.ReadLine();
			foreach (var item in productList.ToList())
			{
				if (item.productID == deleteID)
				{
					productList.Remove(item);
					Console.WriteLine("\nProduct Deleted");
				}
			}
		}
		public static void updateProduct()
		{
			Console.Write("Enter Product ID you want to Update: ");
			string updateID = Console.ReadLine();
			foreach (var item in productList.ToList())
			{
				if (item.productID == updateID)
				{
					Console.WriteLine($"Product ID: {item.productID}\nProduct Name: {item.productName}\nQty: {item.productQty}\nPrice: {item.pricePerUnit}\n");
					Console.WriteLine("1-Update quantity\n2-Update Price");
					Console.Write("what you want update? ");
					string whatUpdate = Console.ReadLine();
					if (whatUpdate == "1")
					{
						Console.Write("Enter New Quntity: ");
						int newQuantity = Convert.ToInt32(Console.ReadLine());
						item.productQty = newQuantity;
						Console.WriteLine("\nProduct Quantity Updated");
					}
					else if (whatUpdate == "2")
					{
						Console.Write("Enter New Price: ");
						double newPrice = Convert.ToDouble(Console.ReadLine());
						item.pricePerUnit = newPrice;
						Console.WriteLine("\nProduct Price Updated");
					}
				}
			}
		}
		public static void viewList()
		{
			foreach (var item in productList)
			{
				Console.WriteLine($"Product ID: {item.productID}\nProduct Name: {item.productName}\nQty: {item.productQty}\nPrice: {item.pricePerUnit}\n");
			}
		}
	}
}
