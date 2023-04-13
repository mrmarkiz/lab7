using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Task2
    {
        public static void Run()
        {
            int choice;
            Array array = new Array(10);
            do
            {
                Console.WriteLine("1 - Min, 2 - Max, 3 - Avg, 4 - Search, 5 - Show");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {array.Min()}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {array.Max()}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {array.Avg()}");
                        break;
                    case 4:
                        int num;
                        Console.Write("Enter value to find: ");
                        if (int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"Result: {array.Search(num)}");
                        }
                        break;
                    case 5:
                        array.Show();
                        break;
                }

            } while (choice != 0);
        }
    }

    
}
