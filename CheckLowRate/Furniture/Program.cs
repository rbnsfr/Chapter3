using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║    Furniture Shop    ║");
            Console.WriteLine("╚══════════════════════╝");
            Console.WriteLine("┌─────────────┬────────┐");
            Console.WriteLine("│   [P]ine    │  $100  │");
            Console.WriteLine("├─────────────┼────────┤");
            Console.WriteLine("│    [O]ak    │  $225  │");
            Console.WriteLine("├─────────────┼────────┤");
            Console.WriteLine("│ [M]ahogany  │  $310  │");
            Console.WriteLine("└─────────────┴────────┘");
            Console.Write("\n Please choose a table to buy: ");

            string choice = Console.ReadLine().ToLower();

            if (choice == "p" || choice == "pine") Console.WriteLine("\n Thank you for choosing the least expensive one, you dirty cheapskate.");
            else if (choice == "o" || choice == "oak") Console.WriteLine("\n Thank you for shopping with us. Now get out.");
            else if (choice == "m" || choice == "mahogany") Console.WriteLine("\n Thank you for burning your money on worthless cosmetics.");
            else Console.WriteLine("\n Since you were too incompetent to follow simple directions, we went ahead and\n charged you with the oak table. Have fun explaining this one to your family.");
        }
    }
}
