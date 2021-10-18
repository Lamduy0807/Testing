using System;
using Function1Testing;
using NUnit.Framework;
namespace UnittestFunction2
{
    public class Test2
    {
        [TestFixture]
        public class TestCase
        {
            [TestCase(28, 1, 2000, true)]
            [TestCase(28, 2, 2000, true)]
            [TestCase(28, 3, 2000, true)]
            [TestCase(28, 4, 2000, true)]
            [TestCase(28, 5, 2000, true)]
            [TestCase(28, 6, 2000, true)]
            [TestCase(28, 7, 2000, true)]
            [TestCase(28, 8, 2000, true)]
            [TestCase(28, 9, 2000, true)]
            [TestCase(28, 10, 2000, true)]
            [TestCase(28, 11, 2000, true)]
            [TestCase(28, 12, 2000, true)]
            [TestCase(28, 13, 2000, false)]
            [TestCase(29, 2, 2009, false)]
            [TestCase(29, 1, 2000, true)]
            [TestCase(30, 1, 2000, true)]
            [TestCase(31, 1, 2000, true)]
            [TestCase(32, 1, 2000, false)]
            [TestCase(0, 1, 2000, false)]

            public void Test_day_in_month(int day, int month, int year, bool result)
            {
                var validDate = new CheckDay();
                Assert.AreEqual(result, validDate.IsValidDate(day,month, year));
            }
        }
    }
}
