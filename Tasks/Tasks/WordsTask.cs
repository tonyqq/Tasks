using System.Linq;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class WordsTask
    {
        public int Solution(string sentence)
        {
            var sentences = sentence.Split('.', '?', '!');

            var maxCount = 0;

            foreach (var item in sentences)
            {
                var noduplicatWhiteSpaces = Regex.Replace(item, @"\s+", " ").TrimEnd().TrimStart();
                var words = noduplicatWhiteSpaces.Split().Where(x => x != "").ToArray();

                var wordCounts = words.Length;
                if (wordCounts > maxCount)
                    maxCount = wordCounts;
            }

            return maxCount;
        }
    }
}