using System;

namespace задачка18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Укажите размер массива");
                int r = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[r];
                int[] a = new int[r];
                int[] b = new int[r];
                int k = 0;
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(10, 20);
                    Console.Write(array[i]);
                    Console.Write(", ");
                }
                Console.WriteLine();
                int first = 0, second = 0;
                Console.WriteLine("Введите загаданное число");
                int chislo = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (i == j)
                        {

                        }
                        else
                        {
                            if (array[j] + array[i] == chislo)
                            {
                                a[k] = i;
                                b[k] = j;
                                k++;
                            }
                        }
                    }
                }
                if (k > 0)
                {
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write($"{a[i]} и ");
                        Console.Write($"{b[i]}");
                        Console.WriteLine();

                    }
                }
                else
                {
                    Console.WriteLine("Загаданного числа нет в массиве");
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
    }
}
