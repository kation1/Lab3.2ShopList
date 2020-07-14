using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3._2ShoppingList
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

            menu.Add("Basil", (decimal)1.99);
            menu.Add("Parsley", (decimal)1.99);
            menu.Add("Chives", (decimal)1.99);
            menu.Add("Rosemary", (decimal)3.99);
            menu.Add("Thyme", (decimal)1.99);
            menu.Add("Cilantro", (decimal)9.99);
            menu.Add("Pepper", (decimal)1.99);
            menu.Add("Salt", (decimal)2.99);

            ArrayList itemsOrdered = new ArrayList();
            ArrayList itemPrices = new ArrayList();


            //menu display

            string userContinue = "y";
            while (userContinue != "n" || userContinue != "n")
            {
                Console.WriteLine("Welcome!\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Item \t \tprice");
                foreach (var item in menu)
                {
                    Console.Write("{0,-10}", item.Key); 
                        Console.WriteLine($"\t{item.Value}\n");
                }

                //Ask User for item selection
                Console.WriteLine("Select an item to purchase:");
                string userItemChoice = Console.ReadLine();

                if (menu.ContainsKey(userItemChoice))
                {
                    itemsOrdered.Add(userItemChoice);
                    itemPrices.Add(menu[userItemChoice]);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"You added {userItemChoice} for {menu[userItemChoice]}");

                    //Ask user if they want to continue
                    Console.WriteLine("Would you like to continue (y/n)");
                    userContinue = Console.ReadLine();
                    Console.WriteLine();
                }
                //Prompt user if item doesn't exist
                else
                {
                    Console.WriteLine($"\n{userItemChoice} was  not a valid response, please try again.");


                }
            }
            Console.Clear();
            //Display items ordered
            Console.WriteLine("Here's the receipt of your order");
            for (int index = 0; index < itemsOrdered.Count; index++)
            {
                Console.WriteLine($"{itemsOrdered[index]}\t {itemPrices[index]}");
            }

            decimal total = 0;
            decimal average = 0;

            for (int index = 0; index < itemsOrdered.Count; index++)
            {
                total += (decimal)itemPrices[index];

            }
            average = total / itemPrices.Count;
            Console.WriteLine();
            //Display average
            Console.WriteLine($"Your Total is ${total}.");
            Console.WriteLine($"The average cost of your items was ${String.Format("{0:0.00}", average)}.");


        }
    }
}
