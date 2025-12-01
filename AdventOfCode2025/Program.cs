using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025
{
    public class Program
    {
        public static void Main()
        {
            Day1.Execute(true);
        }

        public static string[] ReadFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}
