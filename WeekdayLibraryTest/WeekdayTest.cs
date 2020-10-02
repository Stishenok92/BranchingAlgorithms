using Microsoft.VisualStudio.TestTools.UnitTesting;
using static WeekdayLibrary.Weekday;

namespace WeekdayLibraryTest
{
    [TestClass]
    public class WeekdayTest
    {
        [TestMethod]
        public void ToInt_String7_ReturnedInt7()
        {
            //arrange
            string str = "7";
            int expected = 7;
            
            //act
            int actual = ToInt(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ToInt_StringAAA_ExceptionReturned0()
        {
            //arrange
            string str = "AAA";
            int expected = 0;
            
            //act
            int actual = ToInt(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowWeekday_7_ReturnedSunday()
        {
            //arrange
            int numberWeekday = 7;
            string expected = "Sunday";
            
            //act
            string actual = ShowWeekday(numberWeekday);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ShowWeekday_10_ReturnedDefaultMsg()
        {
            //arrange
            int numberWeekday = 10;
            string expected = MSG_INCORRECT_NUMBER_WEEK;
            
            //act
            string actual = ShowWeekday(numberWeekday);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}