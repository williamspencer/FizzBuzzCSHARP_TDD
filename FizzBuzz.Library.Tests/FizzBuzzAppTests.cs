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
            [Values(1, 2, 4, 7, 8, 11, 13, 14)]int input)
        {
            string output = FizzBuzzApp.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void BuzzApp_WhenDiv3_ReturnFizz(
            [Values(3, 6, 9, 12)] int input)
        {
            string output = FizzBuzzApp.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void BuzzApp_WhenDiv5_ReturnsBuzz(
            [Values(5, 10)] int input)
        {
            string output = FizzBuzzApp.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void BuzzApp_WhenDiv3And5_ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzApp.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}