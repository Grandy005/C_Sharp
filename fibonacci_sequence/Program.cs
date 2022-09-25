using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci sequence");
            Console.Write("Add meg meddig menjen: ");
            int range = Convert.ToInt32( Console.ReadLine());
            int counter = 0;
            int num_1 = 0;
            int num_2 = 1;
            int num_3;
            Console.WriteLine(num_1);
            counter++;
            Console.WriteLine(num_2);
            counter++;
            while (true)
            {
                if (range == counter)
                {
                    break;
                }
                Console.WriteLine(num_3 = num_1 + num_2);
                counter++;
                if (range == counter)
                {
                    break;
                }
                Console.WriteLine(num_1 = num_3 + num_2);
                counter++;
                if (range == counter)
                {
                    break;
                }
                Console.WriteLine(num_2 = num_3 + num_1);
                counter++;
                if (range == counter)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
