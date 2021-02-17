using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ConsoleButton
            {
                Boundary = "-",
                Width = 8,
                Height = 20,
                Text = "Button",
                InsideColor = ConsoleColor.Red,
                BoundaryColor = ConsoleColor.Yellow  
            };

            service.Button();

            service.ButtonAction += new Action<int>(Console.WriteLine);
            service.ButtonAction += Console.WriteLine;

            service.ButtonAction += data => Console.WriteLine(data);

            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = integers.Where(integer => integer > 5);

            foreach(var value in result)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
