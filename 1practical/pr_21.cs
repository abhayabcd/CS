using System;                     // Used for basic input/output
using System.Collections.Generic; // Used for List<T>
using System.IO;                  // Used for file handling

// This class represents a single menu item
public class Item
{
    // Name of the food item
    public string Name { get; set; }

    // Price per single item
    public int UnitPrice { get; set; }

    // Quantity ordered by customer
    public int Quantity { get; set; }

    // Method to calculate total price of this item
    public int TotalPrice()
    {
        return UnitPrice * Quantity;
    }
}

class Program
{
    // List to store all menu items dynamically
    static List<Item> menuItems = new List<Item>();

    // Variable to store total daily sales
    static int dailySales = 0;

    static void Main()
    {
        // Adding default items to menu
        menuItems.Add(new Item { Name = "Aalu Puri", UnitPrice = 20 });
        menuItems.Add(new Item { Name = "Sev Puri", UnitPrice = 30 });
        menuItems.Add(new Item { Name = "Pani Puri", UnitPrice = 20 });

        // Asking customer name
        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        // Start order process
        TakeOrder(customerName);
    }

    // Method to handle ordering process
    static void TakeOrder(string customerName)
    {
        int choice; // Stores user menu choice

        // Generate random bill number
        Random random = new Random();
        int billNo = random.Next(1000, 9999);

        // Loop until user chooses to exit
        while (true)
        {
            Console.Clear(); // Clear screen

            Console.WriteLine("====== HOTEL ROYAL ======");
            Console.WriteLine("Customer: " + customerName);
            Console.WriteLine("-------------------------");

            // Display all menu items
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine("{0}. {1} - Rs {2}", i + 1, menuItems[i].Name, menuItems[i].UnitPrice);
            }

            Console.WriteLine("0. Generate Bill & Exit"); // Exit option
            Console.Write("Select Item: ");

            // Read user choice
            choice = Convert.ToInt32(Console.ReadLine());

            // If user chooses 0 → exit loop and generate bill
            if (choice == 0)
                break;

            // If user chooses admin panel
            if (choice == 999)
            {
                AdminPanel();
                continue; // Return back to ordering menu
            }

            // If valid item selected
            if (choice > 0 && choice <= menuItems.Count)
            {
                Console.Write("Enter Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                // Add quantity to selected item
                menuItems[choice - 1].Quantity += qty;

                Console.WriteLine("Item Added Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }

        // After exiting loop, generate bill
        GenerateBill(customerName, billNo);
    }

    // Method to generate final bill
    static void GenerateBill(string customerName, int billNo)
    {
        Console.Clear();

        Console.WriteLine("========== BILL ==========");
        Console.WriteLine("Bill No: " + billNo);
        Console.WriteLine("Customer: " + customerName);
        Console.WriteLine("----------------------------");

        int grandTotal = 0; // Store total bill amount

        // Loop through all menu items
        foreach (Item item in menuItems)
        {
            // Only print items that were ordered
            if (item.Quantity > 0)
            {
                Console.WriteLine("{0}  x {1}  = Rs {2}", item.Name, item.Quantity, item.TotalPrice());

                // Add item total to grand total
                grandTotal += item.TotalPrice();
            }
        }

        Console.WriteLine("----------------------------");
        Console.WriteLine("Grand Total: Rs " + grandTotal);
        Console.WriteLine("Date: " + DateTime.Now);
        Console.WriteLine("Thank You! Visit Again.");

        // Add this bill amount to daily sales
        dailySales += grandTotal;

        // Save bill information in text file
        File.AppendAllText("bill.txt",
            String.Format("Bill No: {0}, Customer: {1}, Total: {2}, Date: {3}\n", billNo, customerName, grandTotal, DateTime.Now));
        String exit;
        Console.WriteLine("\nPress Enter to Exit...");
        exit = Console.ReadLine();
        if (exit == "")
        {
           Main();
        }
    }

    // Method for Admin Panel
    static void AdminPanel()
    {
        while (true) // Keep admin panel running until exit
        {
            Console.Clear();

            Console.WriteLine("====== ADMIN PANEL ======");
            Console.WriteLine("1. View Daily Sales");
            Console.WriteLine("2. View All Bills");
            Console.WriteLine("3. Add New Item");
            Console.WriteLine("4. Remove Item");
            Console.WriteLine("5. Update Item Price");
            Console.WriteLine("0. Exit Admin Panel");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Show today's total sales
                    Console.WriteLine("Daily Sales: Rs " + dailySales);
                    break;

                case 2:
                    // Display saved bills from file
                    if (File.Exists("bill.txt"))
                        Console.WriteLine(File.ReadAllText("bill.txt"));
                    else
                        Console.WriteLine("No Bills Found.");
                    break;

                case 3:
                    // Add new item to menu
                    Console.Write("Enter Item Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Item Price: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    menuItems.Add(new Item { Name = name, UnitPrice = price });

                    Console.WriteLine("Item Added Successfully!");
                    break;

                case 4:
                    // Display items for removal
                    for (int i = 0; i < menuItems.Count; i++)
                        Console.WriteLine("{0}. {1}", i + 1, menuItems[i].Name);

                    Console.Write("Enter Item Number to Remove: ");
                    int removeIndex = Convert.ToInt32(Console.ReadLine());

                    if (removeIndex > 0 && removeIndex <= menuItems.Count)
                    {
                        menuItems.RemoveAt(removeIndex - 1);
                        Console.WriteLine("Item Removed Successfully!");
                    }
                    else
                        Console.WriteLine("Invalid Item Number!");
                    break;

                case 5:
                    // Display items for price update
                    for (int i = 0; i < menuItems.Count; i++)
                        Console.WriteLine("{0}. {1} - Rs {2}", i + 1, menuItems[i].Name, menuItems[i].UnitPrice);

                    Console.Write("Enter Item Number to Update: ");
                    int updateIndex = Convert.ToInt32(Console.ReadLine());

                    if (updateIndex > 0 && updateIndex <= menuItems.Count)
                    {
                        Console.Write("Enter New Price: ");
                        menuItems[updateIndex - 1].UnitPrice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Price Updated Successfully!");
                    }
                    else
                        Console.WriteLine("Invalid Item Number!");
                    break;

                case 0:
                    // Exit admin panel
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
    }
}
