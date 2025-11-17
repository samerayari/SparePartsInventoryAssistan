using System;

class Program
{
    static void Main()
    {
        string part1 = "hydraulic pump";
        string part2 = "plc module";
        string part3 = "servo motor";

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        Console.WriteLine("Which part do you need?");

        while (true)
        {
            string input = Console.ReadLine();
            
            if (input.ToLower() == "do you actually have any parts?")
            {
                Console.WriteLine("We have 3 part(s)!");
                Console.WriteLine(part1);
                Console.WriteLine(part2);
                Console.WriteLine(part3);
                continue;
            }
            
            if (input.ToLower() == "is there anything in stock at all?")
            {
                Console.WriteLine("We have 3 part(s)!");
                Console.WriteLine(part1);
                Console.WriteLine(part2);
                Console.WriteLine(part3);
                continue;
            }
            
            if (input.ToLower() == part1.ToLower())
            {
                Console.WriteLine("I've got " + part1 + " here for you. Bye!");
                break;
            }
            else if (input.ToLower() == part2.ToLower())
            {
                Console.WriteLine("I've got " + part2 + " here for you. Bye!");
                break;
            }
            else if (input.ToLower() == part3.ToLower())
            {
                Console.WriteLine("I've got " + part3 + " here for you. Bye!");
                break;
            }
            else
            {
                Console.WriteLine("I am afraid we don't have any " + input + " in the inventory");
                Console.WriteLine("Which part do you need?");
            }
        }
    }
}
