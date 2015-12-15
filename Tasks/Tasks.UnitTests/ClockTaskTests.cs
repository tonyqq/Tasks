using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks.UnitTests
{
    [TestClass]
    public class ClockTaskTests
    {
        [TestMethod]
        public void TestFromDescription1()
        {
            var clockTask = new ClockTask();

            var interestingPoints = clockTask.Solution("15:15:00", "15:15:12");
            
            Assert.AreEqual(1, interestingPoints);
        }

        [TestMethod]
        public void TestFromDescription2()
        {
            var clockTask = new ClockTask();

            var interestingPoints = clockTask.Solution("22:22:21", "22:22:23");

            Assert.AreEqual(3, interestingPoints);
        }

        [TestMethod]
        public void SameDatesWithNoInterestingPoint()
        {
            var clockTask = new ClockTask();

            var interestingPoints = clockTask.Solution("12:34:56", "12:34:56");

            Assert.AreEqual(0, interestingPoints);
        }

        [TestMethod]
        public void SameDatesWithInterestingPoint()
        {
            var clockTask = new ClockTask();

            var interestingPoints = clockTask.Solution("12:12:12", "12:12:12");

            Assert.AreEqual(1, interestingPoints);
        }

        [TestMethod]
        public void SameDatesWithInterestingPointSameNumber()
        {
            var clockTask = new ClockTask();

            var interestingPoints = clockTask.Solution("11:11:11", "11:11:11");

            Assert.AreEqual(1, interestingPoints);
        }
    }
}
