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
        }
    }
}
