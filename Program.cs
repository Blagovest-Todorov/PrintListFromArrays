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

            string[] reversed = line.Reverse().ToArray();      //  result is - >   7 8   4 5 6     1 2 3

            for (int i = 0; i < line.Length; i++)
            {
                string[] secLine = reversed[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(secLine);
            }

            foreach (string item in result)
            {
                Console.Write($"{item} ");
            }
            
        }
    }
}
