using System;
using System.Collections.Generic;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace skarzycki.robert.unittests._02DaysOff.Tests
{
    [TestFixture]
    public class DaysOffManagerTests
    {
        [Test]
        public void GetAvailableDaysOff_IF_employee_is_experienced_and_hired_not_this_year_THEN_returns_26()
        {
            //Arrange
            const string dummyName = "XYZ";
            var employee = new Employee
            {
                Name = dummyName,
                HasExperience = true,
                Hired = new DateTime(2010, 2, 1)
            };

            var sut = new DaysOffManager();

            //Act
            var result = sut.GetAvailableDaysOff(employee);

            //Assert
            Assert.AreEqual(26, result);
        }

        [Test]
        public void GetAvailableDaysOff_IF_employee_is_null_THEN_throws_exception()
        {
            var sut = new DaysOffManager();
            
            //Act
            Assert.Throws<ArgumentNullException>(()=>sut.GetAvailableDaysOff(null));
        }
    }
}