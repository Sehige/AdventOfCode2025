using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode2025
{
    public class Day1
    {
        public static void Execute(bool bPart2)
        {
            string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            // Insert your path to the .txt file here
            string[] strings = Program.ReadFile(projectPath + "\\Day1\\Day1.txt");
            int nPosition = 50;
            int nCount = 0;

            foreach (string command in strings)
            {
                Console.WriteLine("Position: {0}, Count: {1}",nPosition, nCount );
                int nOldPosition = nPosition;
                char cFirst = command[0];
                string sToChange = command.Substring(1);

                bool bError = int.TryParse(sToChange, out int nRotation);
                if (bError == false || nRotation == -1)
                {
                    Console.WriteLine("Error at parse");
                    continue;
                }

                if (nRotation > 99)
                {
                    if (bPart2 == true)
                    {
                        nCount += nRotation / 100;
                    }
                    nRotation %= 100;
                }

                bool bLeft = cFirst == 'L';

                if (bLeft == true)
                {
                    nPosition -= nRotation;
                }
                else
                {
                    nPosition += nRotation;
                }

                if (nPosition < 0)
                {
                    nPosition = 100 + nPosition;
                    if (bPart2 == true && nPosition != 0 && nOldPosition != 0)
                    {
                        nCount++;
                    }
                }
                if (nPosition > 99)
                {
                    nPosition = Math.Abs(100 - nPosition);
                    if (bPart2 == true && nPosition != 0 && nOldPosition != 0)
                    {
                        nCount++;
                    }
                }

                if (nPosition == 0) nCount++;
            }

            Console.WriteLine(nCount);
        }
    }
}
