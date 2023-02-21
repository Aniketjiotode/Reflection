using System;

namespace _Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           object b= MoodAnalyaserFactory.CreateMoodAnalyaser("_Reflection.MoodAnalyaserFactory", "MoodAnalyaserFactory","HAPPY");
            Console.WriteLine(b.GetType().Name);
        }
    }
}
