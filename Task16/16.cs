using System;
using System.IO;
using System.Collections.Generic;


namespace задачка16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Лиам Донахо\Desktop\number.txt";
            string path2 = @"C:\Users\Лиам Донахо\Desktop\рез.txt";
            Random rnd = new Random();
            int x = rnd.Next(5, 15);
            double[] array = new double[x];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next(1, 30);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            using (StreamWriter dfr = new StreamWriter(path))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    dfr.WriteLine("{0} ", array[i]);
                }
            }
            using (StreamReader str = new StreamReader(path))
            {
                using (StreamWriter dfr = new StreamWriter(path2))
                {
                    string line;
                    while ((line = str.ReadLine()) != null)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = Convert.ToInt32(str.ReadLine());
                            if (array[i] % 2 == 0)
                            {
                                array[i] += 1;
                            }
                            array[i] = Math.Round(array[i] * 0.3, 0);
                            if (array[i]<5)
                            {

                            }
                            else
                            {
                                dfr.WriteLine("{0} ", array[i]);
                            }
                            Console.WriteLine(array[i]);
                        }
                    }
                }
            }



        }
    }
}
