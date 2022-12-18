using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу строчку");
            string stroka = Console.ReadLine();
            string path = "";
            bool d = true;
            while (d)
            {
                Console.WriteLine("Введите фрагмент для поиска");
                string poisk = Console.ReadLine();
                Console.WriteLine("Введите фрагмент для замены");
                string zamena = Console.ReadLine();

                if (stroka.Contains(poisk))
                {
                    stroka = stroka.Replace(poisk, zamena);

                }
                else
                {
                    Console.WriteLine("Менять то блять нечиго");
                }
                Console.WriteLine(stroka);
                using (StreamWriter dfr = new StreamWriter(path))
                {
                    dfr.WriteLine(stroka);
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
