using System;
// int dailysales = 0;
// class Item
// {
//     public string Name;
//     public int Price;
//     public int Quantity;
// }

class menu
{
	static void Main(String[] a)
	{
		int i = 0;
		char c = 'y';
		int[] price = new int[3];
		String[] name = new String[3];
		String customerName;
		Console.Write("Please Enter Your Name: ");
		customerName = Console.ReadLine();
		int[] quantity = new int[3];
		int grandtotal = 0;
		Random r = new Random();
		int billNo = r.Next(1000, 9999);
		Console.WriteLine("+=================================+");
		Console.WriteLine("      === Hotel Royal ===");
		Console.WriteLine("+=================================+");
		Console.WriteLine("Welcome to Hotel Royal, " + customerName);
		while (c == 'y' || c == 'Y')
		{
			Console.Clear();
			int runningTotal = price[0] + price[1] + price[2];
			Console.WriteLine("Current Total: " + runningTotal);
			Console.WriteLine("=== Hotel Menu ===");
			Console.WriteLine("1. Aalu Puri Rs 20/-");
			Console.WriteLine("2. Sev Puri Rs 30/-");
			Console.WriteLine("3. Pani Puri Rs 20/-");
			Console.Write("Please Select Item: ");
			i = Convert.ToInt32(Console.ReadLine());

			switch (i)
			{
				case 1:
					name[0] = "Aalu Puri";
					Console.WriteLine("Thank You for Choosing Item. Please Select Quantity:");
					quantity[0] += Convert.ToInt32(Console.ReadLine());
					price[0] = quantity[0] * 20;
					if (quantity[0] == -1)
					{
						continue;
					}
					if (quantity[0] == -2)
					{
						Console.WriteLine("Aalu Puri Removed");
						quantity[0] = 0;
						price[0] = 0;
					}
					Console.WriteLine("Your Price of Aalu Puri is: {0} * 20 = {1} /-", quantity[0], price[0]);
					break;

				case 2:
					name[1] = "Sev Puri";
					Console.WriteLine("Thank You for Choosing Item. Please Select Quantity:");
					quantity[1] += Convert.ToInt32(Console.ReadLine());
					price[1] = quantity[1] * 30;
					if (quantity[1] == -1)
					{
						continue;
					}
					if (quantity[1] == -2)
					{
						Console.WriteLine("Sev Puri Removed");
						quantity[1] = 0;
						price[1] = 0;
					}
					Console.WriteLine("Your Price of Sev Puri is: {0} * 30 = {1} /-", quantity[1], price[1]);
					break;

				case 3:
					name[2] = "Pani Puri";
					Console.WriteLine("Thank You for Choosing Item. Please Select Quantity:");
					quantity[2] += Convert.ToInt32(Console.ReadLine());
					price[2] = quantity[2] * 20;
					if (quantity[2] == -1)
					{
						continue;
					}
					if (quantity[2] == -2)
					{
						Console.WriteLine("Pani Puri Removed");
						quantity[2] = 0;
						price[2] = 0;
					}
					Console.WriteLine("Your Price of Pani Puri is: {0} * 20 = {1} /-", quantity[2], price[2]);
					break;

				case -1:
					goto end;

				default:
					Console.Clear();
					Console.WriteLine("Sorry, Please Select a Valid Item");
					continue;
			}

			Console.Write("Do You Want to Order More (y/n): ");
			c = Convert.ToChar(Console.ReadLine());
			Console.Clear();
		}
	end:
		Console.WriteLine("Your Order is Successfully Placed");
		Console.WriteLine("=== Total Bill Generated ===");
		Console.WriteLine("Bill No: " + billNo);
		Console.WriteLine("No. Item Name     Quantity  Total Price   Date & Time");
		Console.WriteLine("-------------------------------------------------------------------\n");
		for (i = 0; i < 3; i++)
		{
			if (quantity[i] > 0)
			{
				Console.WriteLine((i + 1) + ".  " + name[i] + "      " + quantity[i] + "          " + price[i] + " /-" + "       " + DateTime.Now);
				grandtotal = grandtotal + price[i];
			}
		}
		Console.WriteLine("-------------------------------------------------------------------\n");
		Console.WriteLine("Grand Total Price is: " + grandtotal + " /-");
		Console.WriteLine("Thank You for Visiting Our Hotel");
	// 	dailysales += grandtotal;
	// 	System.IO.File.AppendAllText("bill.txt",
	// "Customer: " + customerName +
	// " Total: " + grandtotal +
	// " Date: " + DateTime.Now + "\n");

	}
}
