using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contents = File.ReadAllLines("C:/GIT/AdventOfCode2021/Day2/Day2/Day2/day2.txt");

            int horizontal = 0;
            int depth = 0;

            foreach (string command in contents)
            {
                var split = command.Split(' ');

                var cmd = split[0];
                var pos = split[1];

                switch (cmd)
                {
                    case "forward":
                        horizontal = horizontal + int.Parse(pos);
                        break;
                    case "down":
                        depth = depth + int.Parse(pos);
                        break;
                    case "up":
                        depth = depth - int.Parse(pos);
                        break;
                }
            }

            Console.WriteLine($"First answer: {horizontal * depth}");

            horizontal = 0;
            depth = 0;
            int aim = 0;

            foreach (string command in contents)
            {
                var split = command.Split(' ');

                var cmd = split[0];
                var pos = split[1];

                switch (cmd)
                {
                    case "forward":
                        horizontal = horizontal + int.Parse(pos);
                        depth = depth + (aim * int.Parse(pos));
                        break;
                    case "down":
                        aim = aim + int.Parse(pos);
                        break;
                    case "up":
                        aim = aim - int.Parse(pos);
                        break;
                }
            }

            Console.WriteLine($"Second answer: {horizontal * depth}");
        }
    }
}
