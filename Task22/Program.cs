using System;

namespace задача22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Random random = new Random();
            for (int x = 0; x < nums.Length; x++)
            {
                nums[x] = random.Next(0, 100);
                Console.Write(nums[x]);
                Console.Write(" ");
            }
            Console.WriteLine();
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
            Console.Write("Введите число для поиска в массиве ");
            int target = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = 99;
            int rez = 0;
            while (left <= right)
            {
                var middl = (left + right) / 2;
                if (target == nums[middl])
                {
                    Console.WriteLine("Запрашиваемое число есть в массиве под индексом {0}", middl);
                    rez = 1;
                    break;
                }
                else if (target < nums[middl])
                {
                    right = middl - 1;
                }
                else
                {
                    left = middl + 1;
                }
            }
            if (rez != 1)
            {
                Console.WriteLine("Запрашиваемого числа нет в массиве");
            }

            Console.ReadKey();
        }
    }
}
