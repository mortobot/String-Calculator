using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStringEqualsZero()
        {
            //given someone enters an empty string
            var stringToBeEntered = "";
            //when I convert string to int
            var result = CalculateString(stringToBeEntered);
            //then String Calculator returns 0
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void StringOfOneEqualsOne()
        {
            //given someone enters an empty string
            var stringToBeEntered = "1";
            //when I convert string to int
            var result = CalculateString(stringToBeEntered);
            //then String Calculator returns 0
            Assert.AreEqual(1, result);
        }

        public int CalculateString(string numberString)
        {
            if (numberString == "1")
            {
                return 1;
            }
            return 0;
        }
    }

}
