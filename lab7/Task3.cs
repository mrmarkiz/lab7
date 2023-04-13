using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Task3
    {
        public static void Run()
        {
            int choice;
            Array array = new Array(10);
            do
            {
                Console.WriteLine("1 - Show, 2 - SortAsc, 3 - SortDesc, 4 - SortByParam");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        array.Show();
                        break;
                    case 2:
                        array.SortAsc();
                        break;
                    case 3:
                        array.SortDesc();
                        break;
                    case 4:
                        int num;
                        Console.WriteLine("0 - asc 1 - not asc");
                        if (int.TryParse(Console.ReadLine(), out num))
                        {
                            array.SortByParam(Convert.ToBoolean(num));
                        }
                        break;
                }

            } while (choice != 0);
        }
    }
}
