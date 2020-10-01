using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodSensorLibrary;

namespace MoodSensorLibraryTest
{
    [TestClass]
    public class MoodSensorTest
    {
        [TestMethod]
        public void GetRandomNumberTest_RandomFrom0To5_ReturnedFrom0To5()
        {
            //arrange
            int max = 5;

            //act
            int actual = MoodSensor.GetRandomNumber(max + 1);
            
            //assert
            if (actual < 0 || actual > max)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShowSmile_SmileNumber4_ReturnedSmileNumber4()
        {
            //arrange
            int numberSmile = 4;
            string expected = ":‑X";
            
            //act
            string actual = MoodSensor.ShowSmile(numberSmile);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ShowSmile_SmileNumber15_ReturnedDefaultMsg()
        {
            //arrange
            int numberSmile = 15;
            string expected = "Sorry, no suitable smile!";
            
            //act
            string actual = MoodSensor.ShowSmile(numberSmile);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}