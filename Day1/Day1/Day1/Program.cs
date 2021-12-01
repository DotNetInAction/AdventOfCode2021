using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var contents = File.ReadAllLines("C:/GIT/AdventOfCode2021/Day1/Day1/day1.txt");

            var intArray = contents.Select(p => int.Parse(p)).ToArray();

            int increases = 0;            

            for (int i = 1; i < intArray.Count(); i++)
            {
                int current = intArray[i];
                int previous = intArray[i - 1];

                if (current > previous)
                {
                    increases++;
                }
            }

            Console.WriteLine($"First answer: {increases}");

            increases = 0;

            int previousSum = 0;

            for (int i = 0; i < intArray.Count(); i++)
            {
                int first = intArray[i];

                if ((i + 1) > intArray.Length - 1)
                {
                    break;
                }

                int second = intArray[i+1];

                if ((i + 2) > intArray.Length - 1)
                {
                    break;
                }

                int third = intArray[i+2];

                int currentSum = first + second + third;

                if (currentSum > previousSum)
                {
                    increases++;
                }

                previousSum = currentSum;
            }

            Console.WriteLine($"Second answer: {increases - 1 }");
        }
    }
}
