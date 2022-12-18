using System;
using System.Linq;
using System.IO;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Лиам Донахо\Desktop\Исходник.txt";
            string path2 = @"C:\Users\Лиам Донахо\Desktop\Результат.txt";
            string path3 = @"C:\Users\Лиам Донахо\Desktop\Дешифровка.txt";
            string path4 = @"C:\Users\Лиам Донахо\Desktop\шифр1.txt";
            Console.WriteLine("Введите ключ-число");
            string chislo = Console.ReadLine();
            char[] c_h_i_f_r = chislo.ToCharArray();
            using (StreamReader str = new StreamReader(path))
            {
                using (StreamWriter stw = new StreamWriter(path2))
                {
                    string line;
                    string k = "";
                    while ((line = str.ReadLine()) != null)
                    {
                        char[] cvv = line.ToCharArray();
                        foreach (char i in cvv)
                        {
                            k = Convert.ToString(i) + chislo;
                            stw.Write($"{k} ");
                        }
                        stw.WriteLine();
                    }
                }
            }
            Console.WriteLine("Шифрование выполнено");
            Console.ReadKey();
            using (StreamReader dstr = new StreamReader(path2))
            {
                using (StreamWriter dstw = new StreamWriter(path3))
                {
                    string line;
                    string k = "";
                    while ((line = dstr.ReadLine()) != null)
                    {
                        char[] cvv = line.ToCharArray();
                        foreach (char i in cvv)
                        {
                            k = Convert.ToString(i);
                            if (!c_h_i_f_r.Contains(i))
                            {
                                dstw.Write(k);
                            }
                        }
                        dstw.WriteLine();
                    }
                }
            }
            Console.WriteLine("Дешифрование выполнено");
            Console.ReadKey();
            using (StreamReader str = new StreamReader(path))
            {
                using (StreamWriter stw = new StreamWriter(path4))
                {
                    int j = 0;
                    string line;
                    string k = "";
                    while ((line = str.ReadLine()) != null)
                    {
                        char[] cvv = line.ToCharArray();
                        foreach (char i in cvv)
                        {
                            j++;
                            if (j % 2 == 0)
                            {
                                k = Convert.ToString(i) + chislo;
                                stw.Write($"{k} ");
                            }
                            else
                            {
                                k = Convert.ToString(i);
                                stw.Write($"{k} ");
                            }
                        }
                        stw.WriteLine();
                    }
                }
            }
            Console.WriteLine("Шифрование через одного выполнено");
            Console.ReadKey();

        }
    }
}


