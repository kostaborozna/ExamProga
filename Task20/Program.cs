using System;

namespace задача20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Введите число римскими цифрами");
                string chislo = Console.ReadLine();
                char[] array = chislo.ToCharArray();
                int rez = 0;
                int value = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 'I')
                    {
                        value = 1;
                    }
                    if (array[i] == 'V')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'I')
                            {
                                value = 3;
                            }
                            else
                                value = 5;
                        }
                        else
                            value = 5;
                    }
                    if (array[i] == 'X')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'I')
                            {
                                value = 8;
                            }
                            else
                                value = 10;
                        }
                        else
                            value = 10;
                    }
                    if (array[i] == 'L')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'X')
                            {
                                value = 30;
                            }
                            else
                                value = 50;
                        }
                        else
                            value = 50;
                    }
                    if (array[i] == 'C')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'X')
                            {
                                value = 80;
                            }
                            else
                                value = 100;
                        }
                        else
                            value = 100;
                    }
                    if (array[i] == 'D')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'C')
                            {
                                value = 300;
                            }
                            else
                                value = 500;
                        }
                        else
                            value = 500;
                    }
                    if (array[i] == 'M')
                    {
                        if (i > 0)
                        {
                            if (array[i - 1] == 'C')
                            {
                                value = 800;
                            }
                            else
                            {
                                value = 1000;
                            }
                        }
                        else
                            value = 1000;

                    }
                    rez += value;
                }
                Console.WriteLine("Ваше число арабскими цифрами {0}", rez);
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


