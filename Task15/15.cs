using System;
using System.Linq;
using System.IO;

namespace задачка15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Лиам Донахо\Desktop\Результаты.txt";
            Console.WriteLine("Температура в течении месяца в градусах:");
            Random rnd = new Random();
            int[] temperatyra = new int[30];
            for (int i = 0; i < temperatyra.Length; i++)
            {
                temperatyra[i] = rnd.Next(10, 25);
                Console.Write($"{temperatyra[i]} ");
            }
            Console.WriteLine();
            int max = temperatyra.Max();
            int min = temperatyra.Min();
            double sr = 0;
            int sum = 0;
            for (int i = 0; i < temperatyra.Length; i++)
            {
                sum += temperatyra[i];
            }
            sr = sum / temperatyra.Length;
            Console.WriteLine("Средняя температура = {0}, максимальная температура = {1}, минимальная температура = {2}", sr, max, min);
            
            using (StreamWriter dfr = new StreamWriter(path))
            {
                dfr.WriteLine("Средняя температура = {0}, максимальная температура = {1}, минимальная температура = {2}", sr, max, min);
                double otkl = 0;
                for (int i = 0; i < temperatyra.Length; i++)
                {
                    if (temperatyra[i] > sr)
                    {
                        otkl = temperatyra[i] - sr;
                        Console.WriteLine("Температура = {0}, отклонение от средней температуры = +{1}", temperatyra[i], otkl);
                        dfr.WriteLine("Температура = {0}, отклонение от средней температуры = +{1}", temperatyra[i], otkl);
                    }
                    else
                    {
                        otkl = sr - temperatyra[i];
                        Console.WriteLine("Температура = {0}, отклонение от средней температуры = -{1}", temperatyra[i], otkl);
                        dfr.WriteLine("Температура = {0}, отклонение от средней температуры = -{1}", temperatyra[i], otkl);
                    }
                    otkl = 0;
                }
            }

        }
    }
}
