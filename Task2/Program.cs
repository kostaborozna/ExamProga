using System;
using System.Linq;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменная для повтороение програмы. В программе можно добавить try для FormatException
            char restart;
            do
            {
                // Запрашиваем месяц, меняем размер массива, заполняем его
                Console.WriteLine("Месяц");
                int mounth = Convert.ToInt32(Console.ReadLine());
                if (mounth < 1 || mounth > 12)
                {
                    Console.WriteLine("В году 12 месяцев дружочек");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n" + "Повторить? y/n");
                    restart = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Random random = new Random();
                    int[] Uan = new int[31];
                    if (mounth == 2)
                    {
                        Array.Resize(ref Uan, 28);
                    }
                    else if (mounth < 8 && mounth % 2 == 0 || mounth > 7 && mounth % 2 != 0)
                    {
                        Array.Resize(ref Uan, 30);
                    }
                    else
                    {
                        Array.Resize(ref Uan, 31);
                    }
                    for (int i = 0; i < Uan.Length; i++)
                    {
                        Uan[i] = random.Next(7, 70);
                        Console.Write(Uan[i] + " ");

                    }

                    // Находим максимальное и минимальное значение 
                    Console.WriteLine();
                    int max = 0;
                    int min = 0;
                    for (int i = 0; i < Uan.Length; i++)
                    {
                        max = Uan.Max();
                        min = Uan.Min();
                    }
                    Console.WriteLine($"Максимальное значение в месяце: {max}");
                    Console.WriteLine($"Минимальное значение в месяце : {min}");

                    // Обмен
                    Console.WriteLine('\n' + "Введите сумму для обмена");
                    int rub = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Сумма дял обмена по самому выгодному курсу: {rub / min}");

                    // Отклонение от среднего
                    int sum = 0;
                    for (int i = 0; i < Uan.Length; i++)
                    {
                        sum = Uan[i] + sum;
                    }
                    int AvarageValue = sum / Uan.Length;
                    int SumDays = 0;
                    Console.WriteLine('\n' + "Средний курс: " + AvarageValue);
                    Console.WriteLine("Посмотреть отклонение от курса каждого дня? (да / нет)");
                    string y = Console.ReadLine();

                    for (int i = 0; i < Uan.Length; i++)
                    {
                        if (Uan[i] > AvarageValue)
                        {
                            SumDays++;
                        }
                    }

                    if (y == "да" || y == "y")
                    {
                        for (int i = 0; i < Uan.Length; i++)
                        {
                            if (Uan[i] > AvarageValue || Uan[i] < AvarageValue)
                            {
                                Console.WriteLine($"Отклонение от среднего {Uan[i]}");
                            }
                        }
                        Console.WriteLine($"Колличество дней когда курс превышал среднее {SumDays}");
                    }
                    else
                    {
                        Console.WriteLine($"Колличество дней когда курс превышал среднее {SumDays}");
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine("\n" + "Повторить? y/n");
                    restart = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }

            } while (restart == 'y');

        }
    }

}
