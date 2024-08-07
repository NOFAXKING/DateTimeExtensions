using System;
using DateTimeExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateTimeExtensions.Tests
{
    [TestClass]
    public class CameroonTests
    {
        [TestMethod]
        public void TestCameroonHolidays()
        {
            var cultureInfo = new CameroonWorkingDayCultureInfo();

            // Test New Year's Day (January 1st)
            var newYearsDay = new DateTime(2023, 1, 1);
            Assert.IsFalse(cultureInfo.IsWorkingDay(newYearsDay));

            // Test a working day (January 2nd)
            var workingDay = new DateTime(2023, 1, 2);
            Assert.IsTrue(cultureInfo.IsWorkingDay(workingDay));

            // Test Labour Day (May 1st)
            var labourDay = new DateTime(2023, 5, 1);
            Assert.IsFalse(cultureInfo.IsWorkingDay(labourDay));

            // Test National Day (May 20th)
            var nationalDay = new DateTime(2023, 5, 20);
            Assert.IsFalse(cultureInfo.IsWorkingDay(nationalDay));

            // Test Assumption of Mary (August 15th)
            var assumptionOfMary = new DateTime(2023, 8, 15);
            Assert.IsFalse(cultureInfo.IsWorkingDay(assumptionOfMary));

            // Test Christmas Day (December 25th)
            var christmasDay = new DateTime(2023, 12, 25);
            Assert.IsFalse(cultureInfo.IsWorkingDay(christmasDay));
        }
    }
}