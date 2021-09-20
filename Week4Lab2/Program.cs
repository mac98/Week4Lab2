using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp Flowchart Simulation.");
            Console.WriteLine("Is the Lamp working?");
            string input = Console.ReadLine();
            if (input.Contains('y'))
                Console.WriteLine("Sweet! Goodbye.");
            else
            {
                Console.WriteLine("Is the Lamp plugged in?");
                input = Console.ReadLine();
                if (input.Contains('y'))
                {
                    Console.WriteLine("Is the bulb in the Lamp burned out?");
                    input = Console.ReadLine();
                    if (input.Contains('y'))
                        Console.WriteLine("Replace the bulb.");
                    else
                        Console.WriteLine("Bring your Lamp in for repairs.");
                }
                else
                    Console.WriteLine("Plug the Lamp in.");
            }
            Console.ReadLine();
        }
    }
}
