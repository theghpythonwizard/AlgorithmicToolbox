using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = input.Split(' ');
            var a = int.Parse(nums[0]);
            var b = int.Parse(nums[1]);
            Console.WriteLine(a + b);
        }
    }
}