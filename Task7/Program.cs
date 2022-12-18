using System;
using System.IO;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d1 = true;
            while (d1)
            {
                // Переменные path и path2 полный пусть до файла. Otvet 
                string path = @"";
                Console.WriteLine("Введите свою фамилию");
                string fam = Console.ReadLine();
                int ball = 0;
                string otvet = "";
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        if (line.Contains("г)"))
                        {
                            Console.WriteLine("Введите вариант ответа");
                            otvet = Console.ReadLine();
                        }
                        if (line.Contains($"Правильный ответ: {otvet}"))
                        {
                            ball++;
                        }
                    }
                    Console.ReadKey();
                }
                Console.WriteLine("Количество верных ответов");
                Console.WriteLine(ball);
                Console.ReadKey();
                string path2 = @"";
                using (StreamWriter writer = new StreamWriter(path2, true))
                {
                    writer.Write("Фамилия студента ");
                    writer.WriteLineAsync(fam);
                    writer.Write("Количество правильных ответов:");
                    writer.WriteLine(ball);
                }
                Console.WriteLine("Введите дополнительный вопрос");
                string vopr = Console.ReadLine();
                Console.WriteLine("Введите варианты ответов");
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string c = Console.ReadLine();
                string d = Console.ReadLine();
                Console.WriteLine("Введите правильный ответ");
                string prav = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine();
                    writer.WriteLine($"4. {vopr}");
                    writer.WriteLineAsync($"а) {a}");
                    writer.WriteLineAsync($"б) {b}");
                    writer.WriteLineAsync($"в) {c}");
                    writer.WriteLineAsync($"г) {d}");
                    writer.Write("Правильный ответ:");
                    writer.WriteLine(prav);
                }
                Console.WriteLine("Вы закончили? y/n");
                string otvet1 = Console.ReadLine();
                if (otvet1 == "y")
                {
                    d1 = false;
                }
            }
            
        }
    }
}


