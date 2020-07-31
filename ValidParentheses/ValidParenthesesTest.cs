using System;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;

namespace ValidParentheses
{
    public class ValidParenthesesTests
    {
        [Test]
        public void Test1()
        {
            var input = "()";

            var validParentheses = new ValidParentheses();
            var actual = validParentheses.GetOutput(input);
            var expected = true;
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }


        [Test]
        public void Test2()
        {
            var input = "";

            var validParentheses = new ValidParentheses();
            var actual = validParentheses.GetOutput(input);
            var expected = true;
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
    }
}