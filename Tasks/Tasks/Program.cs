using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var clockTask = new ClockTask();
            //Console.WriteLine(clockTask.Solution("15:15:00", "15:15:12"));
            //Console.WriteLine(clockTask.Solution("22:22:21", "22:22:23"));
            //Console.WriteLine(clockTask.Solution("22:22:21", "22:22:21"));
            //Console.WriteLine(clockTask.Solution("01:00:00", "02:00:00"));
            //Console.WriteLine(clockTask.Solution("00:00:00", "01:00:00"));
            //Console.WriteLine(clockTask.Solution("00:00:00", "23:59:59"));

            var wordsTask = new WordsTask();
            Console.WriteLine(wordsTask.Solution("We test coders. Give us a try?"));
            Console.WriteLine(wordsTask.Solution("Forget  CVs..Save time . x x"));
            Console.WriteLine(wordsTask.Solution("...x  .  ????  !!!! x x x"));
            Console.ReadKey();
        }
    }

    // find sentence containing largest number of words
}
