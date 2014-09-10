using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");

            if (Convert.ToDouble(Console.ReadLine()) < 5.65 || Convert.ToDouble(Console.ReadLine()) > 49.99)
            {
                Console.Write("That didn't look right. Type it again: ");

                if (Convert.ToDouble(Console.ReadLine()) < 5.65 || Convert.ToDouble(Console.ReadLine()) > 49.99)
                    Console.WriteLine("ERROR: Your hourly pay rate isn't valid.");
                if (!(Convert.ToDouble(Console.ReadLine()) < 5.65 || Convert.ToDouble(Console.ReadLine()) > 49.99))
                {
                    Console.WriteLine("Pay rate: {0}", Convert.ToString(Convert.ToDouble(Console.ReadLine())));
                    Console.WriteLine("Weekly rate: {0}", (Convert.ToString(Convert.ToDouble(Console.ReadLine()) * 40)));
                }
            }
            if (!(Convert.ToDouble(Console.ReadLine()) < 5.65 || Convert.ToDouble(Console.ReadLine()) > 49.99))
            {
                Console.WriteLine("Pay rate: {0}", Console.ReadLine());
                Console.WriteLine("Weekly rate: {0}", (Convert.ToDouble(Console.ReadLine()) * 40).ToString());
            }
        }
    }
}
