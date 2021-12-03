using System;
using System.IO;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = File.ReadAllLines("C:/GIT/AdventOfCode2021/Day3/Day3/Day3/day3.txt");

            string gamma = string.Empty;

            string epsilon =string.Empty;

            for (int i = 0; i < contents[0].Length; i++)
            {
                int zeroes = 0;
                int ones = 0;

                foreach (string str in contents)
                {
                    _ = str[i] == '0' ? zeroes++ : ones++;
                }

                gamma += zeroes > ones ? "0" : "1";
                epsilon += zeroes > ones ? "1" : "0";
            }

            Console.WriteLine($"First part {Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2)}");

            var mostCommon = contents.ToList();

            var lestCommon = contents.ToList();

            for (int i = 0; i < contents[0].Length; i++)
            {
                if (mostCommon.Count != 1)
                {
                    int zeroCounter = 0;

                    int oneCounter = 0;

                    foreach (string str in mostCommon)
                    {
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;
                    }

                    char oType = (zeroCounter == oneCounter || oneCounter > zeroCounter) ? '1' : '0';

                    foreach (string str in mostCommon.ToList())
                    {
                        if (str[i] != oType)
                        {
                            mostCommon.Remove(str);
                        }
                    }
                }

                if (lestCommon.Count != 1)
                {
                    int zeroes = 0;

                    int ones = 0;

                    foreach (string str in lestCommon)
                    {
                        _ = str[i] == '0' ? zeroes++ : ones++;
                    }

                    char type = (zeroes == ones || ones > zeroes) ? '0' : '1';

                    foreach (string str in lestCommon.ToList())
                    {
                        if (str[i] != type)
                        {
                            lestCommon.Remove(str);
                        }
                    }
                }

                if (mostCommon.Count == 1 && lestCommon.Count == 1)
                {
                    break;
                }
            }

            Console.WriteLine($"Second part: {Convert.ToInt32(mostCommon[0], 2) * Convert.ToInt32(lestCommon[0], 2)}");

        }
    }
}
