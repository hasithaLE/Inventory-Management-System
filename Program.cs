using Inventory_Management_System;

List<Inventory> productList = new List<Inventory>();
Console.WriteLine("*** Inventory Managements System***\n");

while (true)
{
	Console.WriteLine("1. Add a new product\n2. Remove a product\n3. Update the quantity or price\n4. View the list of all products\n");
	Console.Write("Enter the Number: ");
	int input = Convert.ToInt32(Console.ReadLine());

	switch (input)
	{
		case 1:
			Console.Write("Enter Product ID: ");
			string productID = Console.ReadLine();
			Console.Write("Enter Product Name: ");
			string productName = Console.ReadLine();
			Console.Write("Enter Quantity: ");
			int productQty = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Price per unit: ");
			double productPricePU = Convert.ToDouble(Console.ReadLine());

			var product = new Product(productID, productName, productQty, productPricePU);
			var pList = new Inventory(product);
			productList.Add(pList);
			Console.WriteLine("New Product Added\n");
			Console.WriteLine($"Product ID: {productID}\nProduct Name: {productName}\nQty: {productQty}\nPrice: {productPricePU}\n");
			Console.WriteLine("\nEnd");
			break;
		case 2:
			Console.Write("Enter Product ID you want to delete: ");
			string deleteID = Console.ReadLine();
			foreach (var item in productList.ToList())
			{
				if (item.Product.productID == deleteID)
				{
					//productList.Remove(item);
					//Console.WriteLine("\nProduct Deleted");
					Console.WriteLine($"P ID is : {item.Product.productID} P Name is : {item.Product.productName}");
				}
			}
			break;
		case 3:
			Console.Write("Enter Product ID you want to Update: ");
			string updateID = Console.ReadLine();
			foreach (var item in productList.ToList())
			{
				if (item.Product.productID == updateID)
				{
					Console.WriteLine($"Product ID: {item.Product.productID}\nProduct Name: {item.Product.productName}\nQty: {item.Product.productQty}\nPrice: {item.Product.pricePerUnit}\n");
					Console.WriteLine("1-Update quantity\n2-Update Price");
					Console.Write("what you want update? ");
					string whatUpdate = Console.ReadLine();
					if (whatUpdate == "1")
					{
						Console.Write("Enter New Quntity: ");
						int newQuantity = Convert.ToInt32(Console.ReadLine());
						item.Product.productQty = newQuantity;
						Console.WriteLine("\nProduct Quantity Updated");
					}
					else if (whatUpdate == "2")
					{
						Console.Write("Enter New Price: ");
						double newPrice = Convert.ToDouble(Console.ReadLine());
						item.Product.pricePerUnit = newPrice;
						Console.WriteLine("\nProduct Price Updated");
					}
				}
			}
			Console.WriteLine("\nEnd");
			break;
		case 4:
			foreach (var item in productList)
			{
				Console.WriteLine($"Product ID: {item.Product.productID}\nProduct Name: {item.Product.productName}\nQty: {item.Product.productQty}\nPrice: {item.Product.pricePerUnit}\n");
			}
			break;
		default:
			Console.WriteLine("Default Case");
			break;
	}
}
