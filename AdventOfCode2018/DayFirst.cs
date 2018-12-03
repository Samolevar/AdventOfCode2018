using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    class DayFirst
    {
        public (int, List<int>) ParseInput(string fileAddress)
        {
            StreamReader file = new StreamReader(fileAddress);
            var count = 0;
            var list = new List<int>();
            while (true)
            {
                var line = file.ReadLine();
                if (line == null) break;
                count = count + Convert.ToInt32(line);
                list.Add(count);
            }

            return (count, list);
        }

        public int ParseInputSecond(string fileAddress)
        {
            var items = ParseInput(fileAddress);
            var counter = items.Item1;
            while (true)
            {
                var file2 = new StreamReader(fileAddress);
                while (true)
                {
                    var line = file2.ReadLine();
                    if (line == null) break;
                    counter = counter + Convert.ToInt32(line);

                    foreach (var record in items.Item2)
                    {
                        if (counter == record)
                        {
                            return counter;
                        }
                    }
                }
            }
        }
    }
}
