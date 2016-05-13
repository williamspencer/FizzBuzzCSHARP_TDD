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
        public void BuzzApp_When1_Return1()
        {
            string output = FizzBuzzApp.GetValue(1);
            Assert.AreEqual("1", output);
        }
        [Test]
        public void BuzzApp_When2_Return2()
        {
            string output = FizzBuzzApp.GetValue(2);
            Assert.AreEqual("2", output);
        }
    }
}