using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int[] rnd_numbers = new int[5];
            int counter = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.Write("Adj meg egy számot: ");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    foreach (int y in numbers)
                    {
                        if (number != y)
                        {
                            counter++;
                        }
                        else
                        {
                            counter--;
                        }
                    }
                    if (number > 0 && number < 91 && counter == 5)
                    {
                        numbers[x] = number;
                    }
                    else if (counter != 5 && number != 0)
                    {
                        Console.WriteLine("Ezt a számot már megadta!");
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("Hibás számtartomány!");
                        x--;
                    }
                }
                catch
                {
                    Console.WriteLine("Hibás adat!");
                    x--;
                }
                counter = 0;
            }

            Console.WriteLine($"A megadott számok: {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}");

            int[] lotto()
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                int counter_1 = 0;
                int counter_2 = 0;
                int counter_3 = 0;
                Random rnd = new Random();
                while (true)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        int rnd_num = rnd.Next(1, 91);
                        rnd_numbers[x] = rnd_num;
                    }
                    foreach (int num in rnd_numbers)
                    {
                        foreach (int x in rnd_numbers)
                        {
                            if (num != x)
                            {
                                counter_1++;
                            }
                        }
                    }
                    foreach (int num in rnd_numbers)
                    {
                        foreach (int x in numbers)
                        {
                            if (num == x)
                            {
                                counter_2++;
                            }
                        }
                    }
                    if (counter_1 == 20 && counter_2 == 5)
                    {
                        stopwatch.Stop();
                        var ts = stopwatch.ElapsedMilliseconds;
                        var time = $" {ts / 1000}.{ts%1000}";
                        Console.WriteLine($"Kisorsolt számok: {rnd_numbers[0]}, {rnd_numbers[1]}, {rnd_numbers[2]}, {rnd_numbers[3]}, {rnd_numbers[4]}");
                        Console.WriteLine($"Sorsolások száma: {counter_3}");
                        Console.WriteLine($"Sorsolás időtartama: {time}mp");
                        break;
                    }
                    else
                    {
                        counter_1 = 0;
                        counter_2 = 0;
                    }
                    counter_3++;
                }
                return rnd_numbers;
            }
            lotto();
            Console.ReadKey();
        }
    }
}