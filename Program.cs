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
			Inventory.addProduct();

			break;
		case 2:
			Inventory.deleteProduct();
			break;
		case 3:
			Inventory.updateProduct();
			break;
		case 4:
			Inventory.viewList();
			break;
		default:
			Console.WriteLine("Default Case");
			break;
	}
}
