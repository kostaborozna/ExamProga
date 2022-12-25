using System;
class Program
{
    static void Main(string[] args)
    {
        string[] studnets = new string[25] {"Денис Суслов", "Матвей Косарев","Олег Черемисин", "Алексей Шатохин", "Алевтина Агеенкова", "Ксюша Шуберт","Кирилл Сокольников","Екатерина Елкиматалкина", "Иван Макаров",
                                            "Карина Мирная", "Михаил Игнатьев", "Денис Давидюк", "Никита Мирашниченко", "Даша Трубина", "Тимофей Молодцов", "Кирилл Жуков", "Вова Александров", "Артур Хачатрян", "Владимир Филиппов", "Никита Шалашов", "Никита Чувашов", "Макс Баранов", "Глеб Сидоренко", "Георгий Авдоченок", "Никита Бовсуновский" };
        int[] marks = new int[5];
        int[] sum = new int[studnets.Length];
        int[] sred = new int [studnets.Length];
        Random RandomMarks = new Random();
        for (int i = 0; i < studnets.Length; i++)
        {
            Console.WriteLine(studnets[i]);
            for (int j = 0; j < marks.Length; j++)
            {
                marks[j] = RandomMarks.Next(2, 6);
                sum[i] = marks[j] + sum[i];
                Console.WriteLine(marks[j]);
            }
            sred[i] = sum[i] / 5;
            Console.WriteLine($"Средняя оценка {studnets[i]}a: " + sred[i] + '\n');
        }
        int max = sred[0];
        int index = 0;
        for (int i = 0; i < sred.Length; i++)
        {
            if (sred[i] > max)
            {
                max = sred[i];
                index = i;
            }
        }
        Console.WriteLine("Максимальная оценка: " + max + '\n' + "У студента под номером: " + $"{index + 1}");
        Console.ReadKey();
    }


}
