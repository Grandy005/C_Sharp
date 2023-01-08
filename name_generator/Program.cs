using System;
using System.Collections.Generic;
using System.IO;

namespace name_generator
{
    class Program
    {
        static string generateName(string path)
        {
            Random rnd = new Random();
            List<string> names = new List<string>();
            int length = 0;
            string line = "";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    names.Add(line);
                    length++;
                }
            }
            return names[rnd.Next(0, length)];
        }

        static void writeData(List<string> men, List<string> women, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var person in men)
                {
                    sw.WriteLine(person);
                }

                foreach (var person in women)
                {
                    sw.WriteLine(person);
                }

                sw.Close();
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string classes = "ABCDE";
            string person = "";
            List<string> men = new List<string>();
            List<string> women = new List<string>();

            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    person += generateName("/Users/attilaagoston/Downloads/vezeteknevek.txt");
                    person += " ";
                    person = person[0] + person.Substring(1).ToLower();
                    person += generateName("/Users/attilaagoston/Downloads/ferfi.txt");
                    person += ";";
                    person += Convert.ToString(rnd.Next(1, 5) + Convert.ToString(Math.Round(rnd.NextDouble(), 2)).Substring(1));
                    person += ";";
                    person += Convert.ToString(rnd.Next(9, 13));
                    person += classes[rnd.Next(0, classes.Length)];
                    person += ";";
                    person += Convert.ToString(rnd.Next(160, 211)) + "cm";
                    men.Add(person);
                    person = "";
                }
                else
                {
                    person += generateName("/Users/attilaagoston/Downloads/vezeteknevek.txt");
                    person += " ";
                    person = person[0] + person.Substring(1).ToLower();
                    person += generateName("/Users/attilaagoston/Downloads/noi.txt");
                    person += ";";
                    person += Convert.ToString(rnd.Next(1, 5) + Convert.ToString(Math.Round(rnd.NextDouble(), 2)).Substring(1));
                    person += ";";
                    person += Convert.ToString(rnd.Next(9, 13));
                    person += classes[rnd.Next(0, classes.Length)];
                    person += ";";
                    person += Convert.ToString(rnd.Next(150, 181)) +"cm";
                    women.Add(person);
                    person = "";
                }
            }

            writeData(men, women, "statisztika");
        }
    }
}