using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome To Mood Analyzer Problem!!");
            Console.WriteLine("\t\t\t\t    ----------------------------------------");
            string message = "I am very sad";
            MoodAnalyserLogic moodAnalyser = new MoodAnalyserLogic(message);
            System.Console.WriteLine("I am in a {0} mood. ",moodAnalyser.AnalyseMood());
        }
    }

}
