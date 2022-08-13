using System;
// using System.Int64;

namespace Addition
{
    class Program
    {
        private static Int64 MaxPairwiseProduct(Int64[] numbers)
        {
            Int64 result = 0;
            int n = numbers.Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (Convert.ToInt64(numbers[i]) * numbers[j] > result)
                    {
                        result = Convert.ToInt64(numbers[i]) * numbers[j];
                    }
                }
            }
            return result;
        }
        
        private static void RunStressTest()
        {
            int n;
            var tmp = Console.ReadLine();
            n = int.Parse(tmp);
            Int64[] numbers = new Int64[n];
            string[] arrayNumbers = Console.ReadLine().Split();
            for (int i = 0; i < n; ++i)
            {
                numbers[i] = int.Parse(arrayNumbers[i].ToString());
            }

            Int64 result = MaxPairwiseProduct(numbers);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            // Console.Write("input first value: ");
            // var varA = Console.ReadLine();
            // Console.Write("input second value: ");
            // var varB = Console.ReadLine();
            // var intA = int.Parse(varA);
            // var intB = int.Parse(varB);
            // Console.WriteLine(intA + intB);
            // int[] array1 = new int[5];
            // for (int i = 0; i < 5; ++i)
            // {
            //     array1[i] = i;
            // }
            // Console.WriteLine(array1);
            // foreach (int n in array1)
            // {
            //     Console.WriteLine(n);
            // }
            RunStressTest();
        }
    }
}