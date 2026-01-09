using System;
using NUnit.Framework;
using Labb4; // to access Person, Hair, Gender


namespace Labb4.Tests
{
    [TestFixture] // marks this class as a test container
    public class PersonTests
    {
        [Test] // marks this method as a class 
        public void ToString_ReturnsExpectedFormat()
        {
            var hair = new Hair { HairColour = "blond", HairLength = "short" };
            var person = new Person(new DateTime(1990, 1, 1), Gender.Woman, hair, "Blue");

            string result = person.ToString();

            Assert.IsTrue(result.Contains("Blue")); // simple check
        }
    }
}
