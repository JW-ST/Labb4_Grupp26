using NUnit.Framework;
using System;
using System.IO;
using Labb4; 

namespace Labb4.Tests
{
    internal class InputValidatorTests
    {
        [Test]
        public void GetValidHairColour_ReturnsValidHairColour()
        {

            // arrange
            var input = new StringReader("blond\n");
            Console.SetIn(input);
            var validator = new InputValidator();

            // act
            string result = validator.GetValidHairColour();

            // assert
            Assert.AreEqual("blond", result);

        }

        [Test]
        public void GetValidHairColour_RepeatUntilValid_WhenInputIsNumber()
        {
            // arrange - we simulate two different inputs one invalid and one valid 
            var input = new StringReader("123\nblond\n");
            Console.SetIn(input);
            var validator = new InputValidator();

            // act 
            string result = validator.GetValidHairColour();

            // assert 
            Assert.AreEqual("blond", result);
        }


        [Test]
        public void GetValidHairLength_ReturnsValidLength_WhenInputIsLong()
        {
            // arrange 
            var input = new StringReader("long\n");
            Console.SetIn(input);
            var validator = new InputValidator();

            // act 
            string result = validator.GetValidHairLength();

            // assert 
            Assert.AreEqual("long", result);
        }

        [Test]
        public void GetValidHairLentgh_RepeatUntilValid_WhenInputIsValid()
        {
            // arrange 
            var input = new StringReader("123\nblond\nLONG\n");
            Console.SetIn(input);
            var validator = new InputValidator();

            // act 
            string result = validator.GetValidHairLength();

            // assert 
            Assert.AreEqual("long", result);

        }
        [Test]
        public void GetValidBirtDate_RepeatUntilValid_WhenInputIsValid()
        {
            // arrange 
            var input = new StringReader("abc\n2000-03-03\nm\n");
            Console.SetIn(input);
            var validator = new InputValidator();

            // act 
            DateTime result = validator.GetValidBirthDate();

            // assert
            Assert.AreEqual(new DateTime(2000, 03, 03), result);
        }


        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]

        public void GetValidGender_ValidSingleDigitInput_ReturnsExpected(string input, int expected)
        {
            // arrange
            var validator = new InputValidator();
            Console.SetIn(new StringReader(input));

            // act 
            int result = validator.GetValidGender();

            // assert 
            Assert.AreEqual(expected, result);

        }

        [TestCase("abc")]
        [TestCase("000")]
        [TestCase("a")]
        [TestCase("")]
        [TestCase("  1  ")]

        public void GetValidGender_InvalidInput_RePromptUntilValid(string invalidInput)

        {
            // arrange first invalidinput and then "1" 
            var validator = new InputValidator();
            Console.SetIn(new StringReader(invalidInput + Environment.NewLine + "1"));

            // act 
            int result = validator.GetValidGender();

            // assert should return 1 after the 5 testcases 
            Assert.AreEqual(1, result);
        }


    }
}
