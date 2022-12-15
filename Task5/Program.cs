using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            int sum = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 12; i++)
            {
                sum = Convert.ToInt32(sum + 0.7);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
