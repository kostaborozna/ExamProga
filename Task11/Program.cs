using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Игра <Угадай число от 1 до 10>. У вас есть 5 попыток, чтобы угадать");
                Random random = new Random();
                Console.WriteLine("Введите ФИО игрока");
                string name = Console.ReadLine();
                int chislo = random.Next(0, 10);
                //PATH!!!!
                string path = @"C:\Users\admin\Desktop\rez.txt";
                int kolvo = 0;
                string rezyl = "";
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Вводите число, попытка {0}", i + 1);
                    int rez = Convert.ToInt32(Console.ReadLine());
                    if (rez == chislo)
                    {
                        Console.WriteLine("Вы угадали");
                        kolvo++;
                        rezyl = "угадал";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали");
                        rezyl = "не угадал";
                        kolvo++;
                    }
                }
                Console.ReadKey();
                Console.WriteLine("Вы хотите улучшить попытку? y/n");
                string o = Console.ReadLine();
                if (o=="n")
                {
                    using (StreamWriter stw = new StreamWriter(path))
                    {
                        stw.WriteLine("ФИО игрока {0} ", name);
                        stw.WriteLine("Количество попыток {0}", kolvo);
                        stw.WriteLine("Итоговый результат: {0}", rezyl);
                        d = false;
                    }
                }

            }  
        }
    }
}
