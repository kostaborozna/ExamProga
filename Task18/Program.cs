using System;

namespace задачка18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер массива");
            int r = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[r];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
            int first = 0, second = 0;
            Console.WriteLine("Введите загаданное число");
            int chislo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {

                    }
                    else
                    {
                        if (array[j] + array[i] == chislo)
                        {
                            first = j;
                            second = i;
                        }
                    }
                }
            }
            if (first != 0 && second != 0)
            {
                Console.WriteLine("{0} и {1}", first, second);
            }
            else
            {
                Console.WriteLine("Загаданного числа нет в массиве");
            }
            Console.ReadKey();
        }
    }
}
