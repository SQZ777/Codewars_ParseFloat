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
    }

    public class Codewars
    {
        public double? ParseF(object s)
        {
            return null;
        }
    }
}
