using System;

namespace _Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           object b= MoodAnalyaserFactory.CreaateMoodAnalyaser("_Reflection.MoodAnalyaserFactory", "MoodAnalyaserFactory");
            Console.WriteLine(b.GetType().Name);
        }
    }
}
