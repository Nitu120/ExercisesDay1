using System.Drawing;

namespace StatisticsManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] score = new double[] { 1, 3, 5, 7, 9,6,2 };
            
            double AverageScore = GetAverage(score);
            double MinScore = GetMean(score);
            double LargeScore = GetLargestValue(score);
            double SmallScore = GetSmallestValue(score);
            Console.WriteLine($"Average Score is {AverageScore:F2}");
            Console.WriteLine($"Average Score is {MinScore:F2}");
            Console.WriteLine($"Average Score is {LargeScore:F2}");
            Console.WriteLine($"Average Score is {SmallScore:F2}");
        }

        public static double GetAverage(double[] scores) 
        {
            //int[] numbers = new int[7];
            return scores.Average();
        }

        public static double GetMean(double[] scores)
        {
            //int[] numbers = new int[7];
            return scores.Average();
        }
        public static double GetLargestValue(double[] scores)
        { return scores.Max(); 
        }
        public static double GetSmallestValue(double[] scores)
        { return scores.Min(); }
    }
}