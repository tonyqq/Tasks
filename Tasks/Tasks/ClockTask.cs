using System;
using System.Linq;

namespace Tasks
{
    public class ClockTask
    {
        public int Solution(string s1, string s2)
        {
            var d1 = DateTime.Parse(s1);
            var d2 = DateTime.Parse(s2);

            var diff = Math.Abs((d1 - d2).TotalSeconds);

            var totalCount = 0;

            for (long i = 0; i <= diff; i++)
            {
                if (IsInteresting(d1))
                {
                    //Console.WriteLine(d1);
                    totalCount++;
                }
                d1 = d1.AddSeconds(1);
            }
            return totalCount;
        }

        private static bool IsInteresting(DateTime smaller)
        {
            var formatted = smaller.ToString("HH:mm:ss");
            var groupa = formatted.GroupBy(x => x);            
            return groupa.Count() <= 3;
        }
    }
}