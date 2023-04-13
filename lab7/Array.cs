using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        public int[] array { get; set; }

        public Array()
        {
            array = new int[0];
        }

        public Array(int n)
        {
            array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(10);
            }
        }

        public Array(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        public void Show()
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Input string: {info}");
        }
    }
}
