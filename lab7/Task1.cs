using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Task1
    {
        public static void Run()
        {
            int choice;
            Array array = new Array(10);
            do
            {
                Console.WriteLine("1 - show array, 2 - show array and string");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        array.Show();
                        break;
                    case 2:
                        Console.Write("Enter what to print after array: ");
                        string input = Console.ReadLine();
                        array.Show(input);
                        break;
                }
            } while (choice != 0);
        }
    }
}
