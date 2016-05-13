using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzAppTests
    {
        [Test]
        public void BuzzApp_WhenDefault_ReturnInput(
            [Values(1, 2, 4)]int input)
        {
            string output = FizzBuzzApp.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void BuzzApp_When3_ReturnFizz()
        {
            string output = FizzBuzzApp.GetValue(3);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void BuzzApp_When5_ReturnsBuzz()
        {
            string output = FizzBuzzApp.GetValue(5);
            Assert.AreEqual("Buzz", output);
        }
    }
}