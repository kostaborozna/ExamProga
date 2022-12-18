using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static string Zodiak(int d, int m)
        {
            if ((d >= 21 && m == 3) || (d <= 20 && m == 4)) return "Овен";
            if ((d >= 21 && m == 4) || (d <= 20 && m == 5)) return "Телец";
            if ((d >= 21 && m == 5) || (d <= 21 && m == 6)) return "Близнецы";
            if ((d >= 22 && m == 6) || (d <= 22 && m == 7)) return "рак";
            if ((d >= 23 && m == 7) || (d <= 23 && m == 8)) return "лев";
            if ((d >= 24 && m == 8) || (d <= 23 && m == 9)) return "дева";
            if ((d >= 24 && m == 9) || (d <= 23 && m == 10)) return "весы";
            if ((d >= 24 && m == 10) || (d <= 22 && m == 11)) return "скорпион";
            if ((d >= 23 && m == 11) || (d <= 21 && m == 12)) return "стрелец";
            if ((d >= 22 && m == 12) || (d <= 20 && m == 1)) return "козерог";
            if ((d >= 21 && m == 1) || (d <= 18 && m == 2)) return "водолей";
            else return "рыбы";
        }

        static void Main()
        {
            bool d1 = true;
            while (d1)
            {
                Console.WriteLine("Введите дату рождения");
                Console.WriteLine("день ");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("месяц ");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine(Zodiak(d, m));
                Kitay();
                Console.Read();
                Console.WriteLine("Вы закончили? y/n");
                string otvet = Console.ReadLine();
                if (otvet == "y")
                {
                    d1 = false;
                }
            }
        }
        static void Kitay()
        {
            string animal = "";
            string colour = "";
            Console.WriteLine("Введите год (если вы хотите ввести год до н.э до введите значение года с минусовым значением)");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0;

            if (n >= 1984)
            {
                a = (n - 1984) % 60;
            }
            else
            {
                a = 60 - (1984 - n) % 60;
            }

            switch (a % 12)
            {
                case 0:
                    animal = "Крыса";
                    break;
                case 1:
                    animal = "Корова";
                    break;
                case 2:
                    animal = "Тигр";
                    break;
                case 3:
                    animal = "Заяц";
                    break;
                case 4:
                    animal = "Дракон";
                    break;
                case 5:
                    animal = "Змея";
                    break;
                case 6:
                    animal = "Лошадь";
                    break;
                case 7:
                    animal = "Овца";
                    break;
                case 8:
                    animal = "Обезьяна";
                    break;
                case 9:
                    animal = "Петух";
                    break;
                case 10:
                    animal = "Собака";
                    break;
                case 11:
                    animal = "Свинья";
                    break;
            }

            switch (a % 10)
            {
                case 0:
                    colour = "Зелён(ая)(ый)";
                    break;
                case 1:
                    colour = "Зелён(ая)(ый)";
                    break;
                case 2:
                    colour = "Красн(ая)(ый)";
                    break;
                case 3:
                    colour = "Красн(ая)(ый)";
                    break;
                case 4:
                    colour = "Желт(ая)(ый)";
                    break;
                case 5:
                    colour = "Желт(ая)(ый)";
                    break;
                case 6:
                    colour = "Бел(ая)(ый)";
                    break;
                case 7:
                    colour = "Бел(ая)(ый)";
                    break;
                case 8:
                    colour = "Чёрн(ая)(ый)";
                    break;
                case 9:
                    colour = "Чёрн(ая)(ый)";
                    break;
            }

            Console.WriteLine(string.Concat(colour, ' ', animal));
            Console.ReadKey();
        }
    }
}

        
    


