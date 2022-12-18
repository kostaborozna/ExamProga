using System;
using System.Linq;
using System.IO;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                // PathToFile меняем
                string line = Console.ReadLine();
                double path1;
                double path2;
                string PathToFile = @"C:\\Users\admin\source\repos\Task8\anser.txt";
                if (line.Contains('+'))
                {
                    path1 = Convert.ToInt32(line.Substring(0, line.IndexOf('+')));
                    path2 = Convert.ToInt32(line.Substring(line.IndexOf('+') + 1));
                    Console.WriteLine(path1 + path2);
                    CopyToFile(PathToFile, path1, path2, '+');

                }
                if (line.Contains('-'))
                {
                    path1 = Convert.ToInt32(line.Substring(0, line.IndexOf('-')));
                    path2 = Convert.ToInt32(line.Substring(line.IndexOf('-') + 1));
                    Console.WriteLine(path1 - path2);
                    CopyToFile(PathToFile, path1, path2, '-');
                }

                if (line.Contains('*'))
                {
                    path1 = Convert.ToInt32(line.Substring(0, line.IndexOf('*')));
                    path2 = Convert.ToInt32(line.Substring(line.IndexOf('*') + 1));
                    Console.WriteLine(path1 * path2);
                    CopyToFile(PathToFile, path1, path2, '-');
                }

                if (line.Contains('/'))
                {
                    path1 = Convert.ToDouble(line.Substring(0, line.IndexOf('/')));
                    path2 = Convert.ToDouble(line.Substring(line.IndexOf('/') + 1));
                    if (path2 == 0)
                    {
                        Console.WriteLine("На нолик делить нема");
                    }
                    else
                    {
                        Console.WriteLine(path1 / path2);
                        CopyToFile(PathToFile, path1, path2, '/');
                    }

                }
                Console.ReadKey();

                Console.WriteLine("Вы закончили? y/n");
                string otvet = Console.ReadLine();
                if (otvet == "y")
                {
                    d = false;
                }
            }
            
        }
        static string CopyToFile(string PathToFile, double path1, double path2, char sing)
        {
            
            using (StreamWriter writer = new StreamWriter(PathToFile, true))
            {
                writer.WriteLine($"{path1} {sing} {path2}" + '\n');
            }
            return "";
        }
    }
}
