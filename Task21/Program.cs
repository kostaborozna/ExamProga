using System;

namespace задача21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Ваш массив");
                int[] nums = new int[100];
                Random random = new Random();
                for (int x = 0; x < nums.Length; x++)
                {
                    nums[x] = random.Next(0, 100);
                    Console.Write(nums[x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.WriteLine("Сортировка пузырком по возрастанию");
                int temp;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                for (int x = 0; x < nums.Length; x++)
                {

                    Console.Write(nums[x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.WriteLine("Сортировка пузырком по убыванию");
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                for (int x = 0; x < nums.Length; x++)
                {

                    Console.Write(nums[x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
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
