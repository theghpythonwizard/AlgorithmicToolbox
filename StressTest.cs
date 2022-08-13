using System;

namespace Addition
{
    class StressTest
    {
        private static int MaxPairwiseProduct(int[] numbers)
        {
            int result;
            int n = numbers.Length;
            return n;
        }
        public static void Run()
        {
            int n;
            var tmp = Console.ReadLine();
            n = int.Parse(tmp);
            int[] numbers = new int[n];
            foreach (int num in numbers) 
            {
                Console.WriteLine(num);
            }
            // Console.WriteLine(numbers);
            // Console.WriteLine(MaxPairwiseProduct());
        }
    }
}

