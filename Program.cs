using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()               // 1 2 3 |4 5 6 |  7  8 -->Remove |
                         .Split('|');        // read the input create first array,
                                             // 1 2 3    4 5 6      7  8

            List<string> result = new List<string>();

            for (int i = line.Length - 1; i >= 0; i--)
            {
                string[] secLine = line[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(secLine);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
