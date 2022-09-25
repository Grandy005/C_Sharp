using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = 0;
            while (true)
            {
                Console.Write("Adj meg egy számot: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0-nál nagyobb egész számot adj meg!");
                    }
                }
                catch
                {
                    Console.WriteLine("Hibás adat!");
                }
            }
            while (true)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    Console.WriteLine(number);
                    counter++;
                }
                else if (number == 1)
                {
                    break;
                }
                else
                {
                    number = (number * 3) + 1;
                    Console.WriteLine(number);
                    counter++;
                }
            }
            Console.WriteLine($"A programnak {counter} lépésre volt szüksége hogy elérje az ismétlődést ");
            Console.ReadKey();
        }

    }
}

