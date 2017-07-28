using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_a_Shoud_Be_null()
        {
            var codewars = new Codewars();
            var input = "a";
            var actual = codewars.ParseF(input);
            Assert.AreEqual(null,actual);
        }

        [TestMethod]
        public void Input_1_Should_Be_1_0d()
        {
            var codewars = new Codewars();
            var input = "1";
            var actual = codewars.ParseF(input);
            Assert.AreEqual(1.0d, actual);
        }
    }

    public class Codewars
    {
        public double? ParseF(object s)
        {
            var result = Convert.ToDouble(s);
            return result;
        }
    }
}
