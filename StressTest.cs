using System;

namespace Addition
{
    class StressTest
    {
        private static int MaxPairwiseProduct(int[] numbers)
        {
            int result = 0;
            int n = numbers.Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (numbers[i] * numbers[j] > result)
                    {
                        result = numbers[i] * numbers[j];
                    }
                }
            }
            return n;
        }
        
        public static void Run()
        {
            int n;
            var tmp = Console.ReadLine();
            n = int.Parse(tmp);
            int[] numbers = new int[n];
            string[] arrayNumbers = Console.ReadLine().Split();
            for (int i = 0; i < n; ++i)
            {
                numbers[i] = int.Parse(arrayNumbers[i].ToString());
            }

            int result = MaxPairwiseProduct(numbers);
            Console.WriteLine(result);
        }
    }
}

