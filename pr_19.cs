using System;
class menu
{
	static void Main(String[] a)
	{
		int i = 0;
		int q = 0;
		char c = 'y';
		int count = 0;
		int[] price = new int[100];
		int[] total = new int[100];
		String[] name = new String[100];
		int[] quantity = new int[100];
		while (c == 'y' || c == 'Y')
		{
			Console.WriteLine("===Hotel Menu===");
			Console.WriteLine("1. Aalu Puri Rs 20./-");
			Console.WriteLine("2. Save Puri Rs 30./-");
			Console.WriteLine("3 .Pani Puri Rs 20./-");
			Console.Write("Plese Select Item : ");
			i = Convert.ToInt32(Console.ReadLine());
			switch (i)
			{
				case 1:
					name[count] = "Aalu Puri";
					price[count] = 20;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of Aalu Puri is : {0} * 20 = {1} /-", q, q * 20);
					count++;
					break;
				case 2:
					name[count] = "Save Puri";
					price[count] = 30;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of Save Puri is : {0} * 30 = {1} /-", q, q * 30);
					count++;
					break;
				case 3:
					name[count] = "Pani Puri";
					price[count] = 20;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of Pani Puri is : {0} * 20 = {1} /-", q, q * 20);
					count++;
					break;
				default:
					Console.WriteLine("Sorry Please Select Valid Item");
					break;
			}
			quantity[count - 1] = q;
			total[count - 1] = price[count - 1] * quantity[count - 1];
			Console.Write("Do You Want to Order More (y/n): ");
			c = Convert.ToChar(Console.ReadLine());
			Console.Clear();
		}
		int[] item = new int[count];
		Console.WriteLine("Your Order is Successfully Placed");
		Console.WriteLine("===Total Bill Generated===");
		int grandtotal = 0;
		for (i = 0; i < count; i++)
		{
			item[i] = i + 1;
			Console.WriteLine( item[i] +". "+ name[i] + "  Quantity: " + quantity[i] + "  Total Price: " + total[i] + " /-");
			grandtotal = grandtotal + total[i];
		}
		Console.WriteLine("Grand Total Price is : " + grandtotal + " /-");
		Console.WriteLine("Thank You for Visiting our Hotel");
	}
}
