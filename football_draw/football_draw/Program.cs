using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace football_groups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] teams = new string[6][];
            for (int i = 0; i < 6; i++)
            {
                teams[i] = new string[10];
                if (i == 5)
                    teams[i] = new string[3];
            }
            int g_index = 0;
            int t_index = 0;

            using (StreamReader sr = new StreamReader("C:\\Users\\Attila\\source\\repos\\football_draw\\football_draw\\teams1.txt"))
            {
                string line;
                do
                {
                    line = sr.ReadLine() ?? throw new ArgumentException();
                    string trimmed_line = line.TrimEnd('.', ',');
                    if (line.Contains("kalap") == false && trimmed_line != "")
                    {
                        teams[g_index][t_index] = trimmed_line;
                        t_index++;
                    }
                    if (line.Contains("kalap") == true && t_index > 0)
                    {
                        g_index++;
                        t_index = 0;
                    }

                } while (line != ".");
            }

            List<string> drawed_teams = new List<string>();
            string[] draw(string[][] array_of_teams)
            {
                string[] group = new string[5];
                int g_index = 0;
                int t_index;
                Random rnd = new Random();
                while (true)
                {
                    t_index = rnd.Next(0, 10);
                    if (drawed_teams.Contains(array_of_teams[g_index][t_index]) == false)
                    {
                        group[g_index] = array_of_teams[g_index][t_index];
                        drawed_teams.Add(group[g_index]);
                        g_index++;
                        if (g_index == 5)
                        {
                            break;
                        }
                    }
                }
                return group;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. csoport:\n");
                foreach (string item in draw(teams))
                {
                    Console.WriteLine(item);
                }
                if (i > 6)
                {
                    while (true)
                    {
                        Random rnd = new Random();
                        t_index = rnd.Next(0, 3);
                        if (drawed_teams.Contains(teams[5][t_index]) == false)
                        {
                            drawed_teams.Add(teams[5][t_index]);
                            Console.WriteLine(teams[5][t_index]);
                            break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}