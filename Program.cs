﻿using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("input first value: ");
            // var varA = Console.ReadLine();
            // Console.Write("input second value: ");
            // var varB = Console.ReadLine();
            // var intA = int.Parse(varA);
            // var intB = int.Parse(varB);
            // Console.WriteLine(intA + intB);
            int[] array1 = new int[5];
            foreach (int n in array1)
            {
                Console.WriteLine(n);
            }
            StressTest.Run();
        }
    }
}