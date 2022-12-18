using System;

namespace Задача23
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Вводите элементы строкового массива, для остановки введите exit");
                int i = 0;
                string[] numbers = new string[1];
                bool info = true;
                while (info)
                {
                    string input = Console.ReadLine();
                    if (input == "exit")
                    {
                        info = false;
                    }
                    else
                    {
                        Array.Resize(ref numbers, 1 + i);
                        numbers[i] = input;
                        i++;
                    }
                }
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.Write($"{numbers[j]} ");
                }
                Console.ReadKey();
                Console.WriteLine("Вы закончили? y/n");
                string otvet = Console.ReadLine();
                if (otvet=="y")
                {
                    d = false;
                }
            }
            
        }
    }
}
