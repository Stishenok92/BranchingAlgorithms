using Microsoft.VisualStudio.TestTools.UnitTesting;
using static VowelLetterLibrary.VowelLetter;

namespace VowelLetterLibraryTest
{
    [TestClass]
    public class VowelLetterTest
    {
        [TestMethod]
        public void IsSymbol_A_ReturnerTrue()
        {
            //arrange
            string str = "A";
            bool expected = true;
            
            //act
            bool actual = IsSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void IsSymbol_BBB_ReturnerFalse()
        {
            //arrange
            string str = "BBB";
            bool expected = false;
            
            //act
            bool actual = IsSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ToLowerLetter_A_ReturnedSmallA()
        {
            //arrange
            char letter = 'A';
            char expected = 'a';
            
            //act
            char actual = ToLowerLetter(letter);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsVowelLetter_E_ReturnedMsgLetterIsVowel()
        {
            //arrange
            char letter = 'e';
            string expected = MSG_LETTER_IS_VOWEL;
            
            //act
            string actual = IsVowelLetter(letter);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void IsVowelLetter_C_ReturnedMsgIsConsonant()
        {
            //arrange
            char letter = 'c';
            string expected = MSG_LETTER_IS_CONSONANT;
            
            //act
            string actual = IsVowelLetter(letter);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefinitionSymbol_A67_ReturnedMsgIsString()
        {
            //arrange
            string str = "A67";
            string expected = MSG_IS_STRING;
            
            //act
            string actual = DefinitionSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void DefinitionSymbol_7_ReturnedMsgSymbolIsNotLetter()
        {
            //arrange
            string str = "7";
            string expected = MSG_SYMBOL_IS_NOT_LETTER;
            
            //act
            string actual = DefinitionSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void DefinitionSymbol_K_ReturnedMsgIsConsonant()
        {
            //arrange
            string str = "K";
            string expected = MSG_LETTER_IS_CONSONANT;
            
            //act
            string actual = DefinitionSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void DefinitionSymbol_I_ReturnedMsgLetterIsVowel()
        {
            //arrange
            string str = "I";
            string expected = MSG_LETTER_IS_VOWEL;
            
            //act
            string actual = DefinitionSymbol(str);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}