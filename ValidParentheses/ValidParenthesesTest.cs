using System;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework;

namespace ValidParentheses
{
    public class ValidParenthesesTests
    {
        private bool _actual;
        private string _input;
        private ValidParentheses _validParentheses;

        public ValidParenthesesTests()
        {
            _validParentheses = new ValidParentheses();
        }

        [Test]
        public void Test1()
        {
            GivenInput("()");

            WhenValidParentheses();

            ShouldBe(true);
        }

        [Test]
        public void Test2()
        {
            GivenInput("");

            WhenValidParentheses();

            ShouldBe(true);
        }

        [Test]
        public void Test3()
        {
            GivenInput("[");

            WhenValidParentheses();

            ShouldBe(false);
        }

        [Test]
        public void Test4()
        {
            GivenInput("((");

            WhenValidParentheses();

            ShouldBe(false);
        }

        [Test]
        public void Test5()
        {
            GivenInput("[])");

            WhenValidParentheses();

            ShouldBe(false);
        }

        private void ShouldBe(bool compareResult)
        {
            Assert.AreEqual(compareResult, _actual);
        }

        private void WhenValidParentheses()
        {
            _actual = _validParentheses.GetOutput(_input);
        }

        private void GivenInput(string input)
        {
            _input = input;
        }
    }
}