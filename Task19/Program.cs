using System;

namespace задача19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Введите слово или число чтобы проверить, является оно палиндромом или нет");
                string text = Console.ReadLine();
                char[] obrtext = text.ToCharArray();
                Array.Reverse(obrtext);
                string finaltext = new string(obrtext);
                if (text == finaltext)
                {
                    Console.Write("true");
                }
                else
                {
                    Console.Write("false");
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
