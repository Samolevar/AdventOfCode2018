using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    class Day1
    {
        public void Task1_1()
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

        public void Task1_2()
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
