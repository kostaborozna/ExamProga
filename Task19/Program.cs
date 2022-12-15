using System;

namespace задача19
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
