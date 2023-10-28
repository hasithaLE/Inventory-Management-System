using Inventory_Management_System;

List<Product> productList = new List<Product>();
Console.WriteLine("*** Inventory Managements System***\n");

while (true)
{
	Console.WriteLine("1. Add a new product\n2. Remove a product\n3. Update the quantity or price\n4. View the list of all products\n");
	Console.Write("Enter the Number: ");
	int input = Convert.ToInt32(Console.ReadLine());

	switch (input)
	{
		case 1:
			Console.WriteLine("Case 1");
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
			Console.WriteLine($"Product ID: {productID}\nProduct Name: {productName}\nQty: {productQty}\nPrice: {productPricePU}\n");
			Console.WriteLine("\nEnd");
			break;
		case 2:
			Console.WriteLine("Case 2");
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
			Console.WriteLine("\nEnd");
			break;
		case 3:
			Console.WriteLine("Case 3");
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
			Console.WriteLine("\nEnd");
			break;
		case 4:
			Console.WriteLine("Case 4");
			foreach (var item in productList)
			{
				Console.WriteLine($"Product ID: {item.productID}\nProduct Name: {item.productName}\nQty: {item.productQty}\nPrice: {item.pricePerUnit}\n");
			}
			Console.WriteLine("\nEnd");
			break;
		default:
			Console.WriteLine("Default Case");
			break;
	}
}
