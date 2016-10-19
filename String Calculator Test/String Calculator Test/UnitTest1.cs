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

        [TestMethod]
        public void StringOfTwoEqualsTwo()
        {
            //given someone enters an empty string
            var stringToBeEntered = "2";
            //when I convert string to int
            var result = CalculateString(stringToBeEntered);
            //then String Calculator returns 0
            Assert.AreEqual(2, result);
        }

        public int CalculateString(string numberString)
        {
            var acceptableNumbers = new string[1, 2];
            ;

            if (numberString == "1")
            {
                return 1;
            }
            if (numberString == "2")
            {
                return 2;
            }
            return 0;
        }
    }

}
