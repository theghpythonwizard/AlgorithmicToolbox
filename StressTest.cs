using System;

namespace Addition
{
    class StressTest
    {
        private static int MaxPairwiseProduct(int[] numbers)
        {
            int result = 0;
            int n = numbers.Length;
            return n;
        }
        
        public static void Run()
        {
            int n;
            var tmp = Console.ReadLine();
            n = int.Parse(tmp);
            int[] numbers = new int[n];
            for (int i = 0; i < n; ++i)
            {
                int input = Console.ReadLine();
                numbers[input]
            }

            int result = MaxPairwiseProduct(numbers);
            Console.WriteLine(result);
        }
    }
}

