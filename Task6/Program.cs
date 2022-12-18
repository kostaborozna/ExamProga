using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                string[] names = new string[10] {"Ахмед", "Махмуд", "Равшан", "Ораш", "Мухамед", "Рустам", "Адам",
            "Леонид", "Макар", "Салам"};
                int[] marks = new int[5];
                Random random = new Random();
                int[] sum = new int[10];
                int[] sred = new int[10];
                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i] + "\n");
                    for (int j = 0; j < marks.Length; j++)
                    {
                        marks[j] = random.Next(1, 10);
                        sum[i] = marks[j] + sum[i];
                        Console.Write(marks[j] + " \n");
                    }
                    sred[i] = sum[i] / 5;
                    Console.WriteLine($"Средняя оценка {names[i]}a: " + sred[i]);
                    Console.WriteLine();
                }
                int max = sred[0];
                int index = 0;
                for (int i = 0; i < sred.Length; i++)
                {
                    if (sred[i] > max)
                    {
                        max = sred[i];
                        index = i;
                    }
                }
                Console.WriteLine("Максимальная оценка: " + max + '\n' + "У спортсмена под номером: " + $"{index + 1}");
                Console.ReadKey();
                Console.WriteLine("Вы закончили? y/n");
                string otvet = Console.ReadLine();
                if (otvet == "y")
                {
                    d = false;
                }
            }
        }
    }
}
