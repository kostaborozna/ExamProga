using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Введите сумму вклада");
                double sum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите количество месяцев");
                int mes = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < mes; i++)
                {
                    sum += sum * 0.07;
                }
                Console.WriteLine(Math.Round(sum, 2));
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
