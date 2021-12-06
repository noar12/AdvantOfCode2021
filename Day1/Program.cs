using System;
using System.IO;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}{Path.DirectorySeparatorChar}AdvantOfCodeInput{Path.DirectorySeparatorChar}";
            StreamReader reader = new StreamReader($"{folder}inputDay1-1.txt");
            List<int> measures = new List<int>();
            while (!reader.EndOfStream)
            {
                int.TryParse(reader.ReadLine(), out int current);
                measures.Add(current);
            }
            
            int directIncreasingCount = DirectCompare(measures);
            int threeMeasureIncreasingCount = ThreeMeasuresCompare(measures);
            Console.WriteLine(threeMeasureIncreasingCount);

        }

        private static int DirectCompare(List<int> measures)
        {
            int increasingCount = 0;
            for (int i = 0; i < measures.Count; i++)
            {
                if (i != 0)
                {
                    if (measures[i] > measures[i - 1])
                        increasingCount++;

                }
            }

            return increasingCount;
        }

        private static int ThreeMeasuresCompare(List<int> measures)
        {
            int increasingCount = 0;
            for (int i = 0; i < measures.Count; i++)
            {
                if (i > 2)
                {
                    int a = measures[i-1] + measures[i - 2] + measures[i - 3];
                    int b = measures[i] + measures[i - 1] + measures[i - 2];
                    if (b>a)
                    {
                        increasingCount++;
                    }
                }
            }
            return increasingCount;
        }
    }
}
