using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task1_1();
            //            Task1_2();
            //            Task2_1();
            Task2_2();
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
                        isFinished = true;
                        break;
                    }

                    dictionary.Add(result, 1);
                }
            }

            Console.WriteLine(result);
        }

        public static void Task2_1()
        {
            var input_task1 = File.ReadAllLines(Directory.GetCurrentDirectory() + @"..\..\..\..\data\input_task2.txt");

            var twoChars = 0;
            var threeChars = 0;
            var dictionary = new Dictionary<int, int>();
            foreach (var str in input_task1)
            {
                var listChars = str.ToCharArray();
                foreach (var item in listChars)
                {
                    if (dictionary.ContainsKey(item))
                        dictionary[item]++;
                    else
                        dictionary.Add(item, 1);
                }
                twoChars += dictionary.ContainsValue(2) ? 1 : 0;
                threeChars += dictionary.ContainsValue(3) ? 1 : 0;
                dictionary.Clear();
            }

            var result = twoChars * threeChars;
            Console.WriteLine(result);
        }

        public static void Task2_2()
        {
            var input_task = File.ReadAllLines(Directory.GetCurrentDirectory() + @"..\..\..\..\data\input_task2.txt");

            for (var i = 0; i < input_task.Length; i++)
            {
                var first = input_task[i];
                for (var j = i + 1; j < input_task.Length; j++)
                {
                    var second = input_task[j];
                    var countError = 0;
                    var result = "";
                    for (var k = 0; k < first.Length; k++)
                    {
                        if (first[k] != second[k])
                        {
                            if (countError == 2)
                                break;
                            countError++;
                        }
                        else
                        {
                            result += first[k];
                        }
                    }

                    if (countError < 2)
                    {
                        Console.WriteLine(first + "-" + second+"-"+result);
                    }
                }
            }
        }
    }
}
