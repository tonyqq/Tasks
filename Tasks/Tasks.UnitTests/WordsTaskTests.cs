using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks.UnitTests
{
    [TestClass]
    public class WordsTaskTests
    {
        [TestMethod]
        public void FromDesctiptionTest1()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("We test coders. Give us a try?");

            Assert.AreEqual(4, maxCounts);
        }

        [TestMethod]
        public void FromDesctiptionTest2()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("Forget  CVs..Save time . x x");

            Assert.AreEqual(2, maxCounts);
        }

        [TestMethod]
        public void MultipleDelimiters()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("...x.  ???? !!!!x x x");

            Assert.AreEqual(3, maxCounts);
        }

        [TestMethod]
        public void OnlyDelimiters()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("....!!!????");

            Assert.AreEqual(0, maxCounts);
        }

        [TestMethod]
        public void EmptyString()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("");

            Assert.AreEqual(0, maxCounts);
        }

        [TestMethod]
        public void OnlyWhiteSpace()
        {
            var wordsTask = new WordsTask();

            var maxCounts = wordsTask.Solution("    ");

            Assert.AreEqual(0, maxCounts);
        }
    }
}