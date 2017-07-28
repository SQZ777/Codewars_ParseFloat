using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_a100_Shoud_Be_null()
        {
            GetValue(null, "a100");
        }

        [TestMethod]
        public void Input_1_Should_Be_1_0d()
        {
            GetValue(1.0d, "1");
        }

        [TestMethod]
        public void Input_a_Shoud_Be_null()
        {
            GetValue(null, "a");
        }

        [TestMethod]
        public void Input_null_Shoud_Be_null()
        {
            GetValue(null, null);
        }

        private static void GetValue(object expected, object input)
        {
            var codewars = new Codewars();
            var actual = codewars.ParseF(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Codewars
    {
        public double? ParseF(object s)
        {
            if (string.IsNullOrEmpty(s as string))
                return null;
            try
            {
                var result = Convert.ToDouble(s);
                return result;
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }
}
