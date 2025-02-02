﻿using DateTimeExtensions.WorkingDays;
using NUnit.Framework;
using System;

namespace DateTimeExtensions.Tests
{
    [TestFixture]
    internal class enJMHolidaysTests
    {
        private readonly WorkingDayCultureInfo dateTimeCulture = new WorkingDayCultureInfo("en-JM", "Jamaica");
        [Test]
        public void SundayChristmass2022()
        {//Holiday's falling on Sunday are observed on the following monday.
            //boxing day was the 26th, a monday, which would result in a clash, hence the clashing holiday would be observed on the following day (Tuesday)
            var date = new DateTime(2022, 12, 25);
            TestHoliday(dateTimeCulture, date);
        }
        private void TestHoliday(IWorkingDayCultureInfo workingDayCultureInfo, DateTime dateOnGregorian)
        {
            var isHoliday = workingDayCultureInfo.IsHoliday(dateOnGregorian);
            Assert.IsTrue(isHoliday);
        }
    }
}
