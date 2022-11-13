using System;
using System.Collections.Generic;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        int date;
        string roman_date = "";
        Dictionary<int, string> roman = new Dictionary<int, string>();

        roman.Add(1, "I");
        roman.Add(4, "IV");
        roman.Add(5, "V");
        roman.Add(9, "IX");
        roman.Add(10, "X");
        roman.Add(40, "XL");
        roman.Add(50, "L");
        roman.Add(90, "XC");
        roman.Add(100, "C");
        roman.Add(400, "CD");
        roman.Add(500, "D");
        roman.Add(900, "CM");
        roman.Add(1000, "M");

        do
        {
            Console.Write("Adj meg egy évszámot 0-tól 3999-ig: ");
            date = Convert.ToInt32(Console.ReadLine());
        } while (date < 1 || date > 3999);

        foreach (var item in roman.Reverse())
        {
            while (item.Key <= date)
            {
                roman_date += item.Value;
                date -= item.Key;
            }
        }

        Console.WriteLine($"\nA dátum római számokkal: {roman_date}");
    }
}