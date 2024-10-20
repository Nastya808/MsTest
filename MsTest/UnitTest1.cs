using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateTimeApp.Tests
{
    [TestClass]
    public class DateInputHelperTests
    {
        [DataTestMethod]
        [DataRow("2024", 1, 9999, 2024)] 
        [DataRow("12", 1, 12, 12)]       
        [DataRow("31", 1, 31, 31)]       
        [DataRow("23", 0, 23, 23)]      
        public void ReadInput_ValidInput_ReturnsValue(string input, int min, int max, int expected)
        {
            int result = DateInputHelper.ReadInput("Тест", min, max, input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("abcd", 1, 12)]         
        [DataRow("10000", 1, 9999)]      
        [DataRow("-5", 0, 23)]          
        public void ReadInput_InvalidInput_ThrowsException(string input, int min, int max)
        {
            Assert.ThrowsException<ArgumentException>(() =>
                DateInputHelper.ReadInput("Тест", min, max, input));
        }

        [TestMethod]
        public void CreateDateTime_ValidData_ReturnsDateTime()
        {
            int year = 2024;
            int month = 2;
            int day = 29;
            int hour = 12;
            int minute = 30;

            DateTime result = DateInputHelper.CreateDateTime(year, month, day, hour, minute);

            Assert.AreEqual(new DateTime(2024, 2, 29, 12, 30, 0), result);
        }

        [TestMethod]
        public void CreateDateTime_InvalidDay_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                DateInputHelper.CreateDateTime(2024, 2, 30, 12, 30));
        }
    }
}
