using System;
using System.Collections.Generic;

class SparePartsInventoryAssistant
{
    static void Main(string[] args)
    {
        List<string> inventory = new List<string>()
        {
            "hydraulic pump",
            "PLC module",
            "servo motor"
        };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");

        while (true)
        {
            Console.Write("Which part do you need? ");
            string part = Console.ReadLine();
            
            if (part.Equals("Do you actually have any parts?", StringComparison.OrdinalIgnoreCase)
                || part.Equals("Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"We have {inventory.Count} part(s)!");
                foreach (var p in inventory)
                {
                    Console.WriteLine(p);
                }
            }
           
            else if (inventory.Contains(part))
            {
                Console.WriteLine($"I've got {part} here for you 😊. Bye!");
                break; 
            }
            else
            {
                Console.WriteLine($"I am afraid we don't have any {part} in the inventory 😔");
            }
        }
    }
}
