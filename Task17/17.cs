using System;

namespace задачка17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 4];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rnd.Next(20, 50);
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов в каждой строчке");
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.WriteLine("Сумма элементов в каждом столбце");
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum += array[i, j];
                }
                Console.Write(sum);
                Console.Write(" ");
                sum = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов главной диагонали");
            for (int i = 6 - 1; i >= 0; --i)
            {
                for (int j = 4 - 1; j >= 0; --j)
                {
                    if (i == j)
                        sum += array[i, j];
                }
            }
            Console.WriteLine(sum);
            sum = 0;
            Console.WriteLine("Количество элементов главной диагонали, которые меньше 10");
            for (int i = 6 - 1; i >= 0; --i)
            {
                for (int j = 4 - 1; j >= 0; --j)
                {
                    if (i == j)
                    {
                        if (array[i,j]<10)
                            sum += 1;
                    }
                        
                }
            }
            Console.WriteLine(sum);
        }
    }
}
