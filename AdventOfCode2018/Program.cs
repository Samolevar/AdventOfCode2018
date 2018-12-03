using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1_1();
            Task1_2();
            Console.Read();
        }

        private static void Task1_1()
        {
            var input_task1 = File.ReadAllLines(Directory.GetCurrentDirectory() + @"..\..\..\..\data\input_task1.txt");
            var result = 0;
            foreach (var item in input_task1)
            {
                var sign = item[0];
                result += (sign == '+') ? int.Parse(item.Substring(1)) : (-1) * int.Parse(item.Substring(1));
            }

            Console.WriteLine(result);
        }

        private static void Task1_2()
        {
            var input_task1 = File.ReadAllLines(Directory.GetCurrentDirectory() + @"..\..\..\..\data\input_task1.txt");
            var result = 0;
            var dictionary = new Dictionary<int, int>();
            var isFinished = false;
            while (!isFinished)
            {
                foreach (var item in input_task1)
                {
                    var sign = item[0];
                    result += (sign == '+') ? int.Parse(item.Substring(1)) : (-1) * int.Parse(item.Substring(1));
                    if (dictionary.ContainsKey(result))
                    {
                        Console.WriteLine(result);
                        isFinished = true;
                        break;
                    }

                    dictionary.Add(result, 1);
                }
            }

            Console.WriteLine(result);
        }
    }
}
