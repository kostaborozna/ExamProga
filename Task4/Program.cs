using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Введите зарплату работника за месяц (от 1000$ до 5000$)");
                int salary = Convert.ToInt32(Console.ReadLine());
                int mounth = 12;
                double sum = 0;
                double[] Arry = new double[mounth + 1];

                Console.WriteLine("Зарплата сотрудника при условии что он не пропустил ни один день");
                for (int i = 1; i < Arry.Length; i++)
                {
                    if (i == 2)
                    {
                        Arry[i] = salary / 28 * 28;
                        sum = Arry[i] + sum;
                    }
                    else if ((i < 8 && i % 2 == 0) || (i > 7 && i % 2 == 0))
                    {
                        Arry[i] = salary / 30 * 30;
                        sum = Arry[i] + sum;
                    }
                    else
                    {
                        Arry[i] = salary / 31 * 31;
                        sum = Arry[i] + sum;
                    }
                    Console.Write(Arry[i] + " ");
                }

                Console.WriteLine("\n\nОбщая сумма за год: " + sum);
                string avarage = (sum / mounth).ToString("f1");
                Console.WriteLine("Средняя зарплата за год: " + avarage + '\n');
                BabkaPrint(Arry);
                Console.WriteLine('\n' + "Общие отчисления в песнионный фонд: " + BabkaOtch(Arry) + '\n');
                Deviations(Arry, sum, mounth);
                FindMaxMin(Arry);
                Console.ReadKey();

                Console.WriteLine("Вы закончили? y/n");
                string otvet = Console.ReadLine();
                if (otvet == "y")
                {
                    d = false;
                }
            }
            
        }
        public static double FindMaxMin(double[] Arry)
        {
            double min = Arry[1];
            double max = Arry[0];
            for (int i = 1; i < Arry.Length; i++)
            {
                if (Arry[i] < min)
                {
                    min = Arry[i];
                }
                if (Arry[i] > max)
                {
                    max = Arry[i];
                }
            }
            Console.WriteLine("Максимальное значение: " + max + '\n' + "Минимальное значение: " + min);

            return 0;
        }
        public static double Deviations(double[] Arry, double sum, int month)
        {
            int avarage = Convert.ToInt32(sum / month);
            for (int i = 1; i < Arry.Length; i++)
            {
                if (Arry[i] > avarage || Arry[i] < avarage)
                {

                    Console.WriteLine("Отклонение от средней зарплаты в месяце " + i + " на " + Arry[i]);
                }
            }
            return 0;
        }
        public static double BabkaPrint(double[] Arry)
        {
            Console.WriteLine("Отчисление за месяц: ");
            double[] BabkaPrint = new double[Arry.Length];
            for (int i = 1; i < BabkaPrint.Length; i++)
            {
                BabkaPrint[i] = Arry[i];
            }
            for (int i = 1; i < BabkaPrint.Length; i++)
            {
                Console.Write(BabkaPrint[i] * 0.2 + " ");
            }
            return 0;
        }
        public static double BabkaOtch(double[] Arry)
        {
            double otch = 0;
            double[] ArryOtch = new double[Arry.Length];
            for (int i = 1; i < ArryOtch.Length; i++)
            {
                ArryOtch[i] = Arry[i];
            }
            for (int i = 1; i < ArryOtch.Length; i++)
            {
                ArryOtch[i] = ArryOtch[i] * 0.2;
                otch = ArryOtch[i] + otch;
            }
            return otch;
        }


    }
}