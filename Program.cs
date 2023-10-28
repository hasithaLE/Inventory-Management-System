using Inventory_Management_System;

Console.WriteLine("*** Inventory Managements System***\n");
Console.WriteLine("1. Add a new product\n2. Remove a product\n3. Update the quantity or price\n4. View the list of all products\n");
Console.Write("Enter the Number: ");
int input = Convert.ToInt32(Console.ReadLine());
List<Product> productList = new List<Product>();

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

		var product = new Product(productID,productName,productQty,productPricePU);
		productList.Add(product);
		Console.WriteLine("New Product Added\n");
        foreach (var item in productList)
        {
			Console.WriteLine($"Product ID: {item.productID}\nProduct Name: {item.productName}\nQty: {item.productQty}\nPrice: {item.pricePerUnit}");
        }
        Console.WriteLine("\nEnd");
		break;
	case 2:
		Console.WriteLine("Case 2");
		break;
	case 3:
		Console.WriteLine("Case 3");
		break;
	case 4:
		Console.WriteLine("Case 4");
		break;
	default:
		Console.WriteLine("Default Case");
		break;
}

