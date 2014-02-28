using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;

namespace ExtensionsTesting
{
    [TestClass]
    public class DateTimeExtensionsTest
    {
        [TestMethod]
        public void DatesEqualTest()
        {
            DateTime a = new DateTime(2014, 2, 27);
            DateTime b = new DateTime(2014, 2, 27);

            Assert.IsTrue(a.DatesEqual(b));
        }

        [TestMethod]
        public void DatesUnequalTest()
        {
            DateTime a = new DateTime(2014, 2, 27);
            DateTime b = new DateTime(2014, 2, 28);

            Assert.IsFalse(a.DatesEqual(b));
        }
    }
}
