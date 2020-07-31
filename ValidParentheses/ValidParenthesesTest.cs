using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    }

    public class ValidParentheses
    {
        char[] leftParentheses = new[] {'(', '{', '['};
        char[] rightParentheses = new[] {')', '}', ']'};

        public bool GetOutput(string input)
        {
            var parenthesesMatch = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{'},
            };

            var stack = new Stack<char>();

            var firstTop = input.ToCharArray().First();
            if (rightParentheses.Contains(firstTop))
            {
                return false;
            }

            foreach (var parentheses in input)
            {
                if (leftParentheses.Contains(parentheses))
                {
                    stack.Push(parentheses);
                }

                if (rightParentheses.Contains(parentheses))
                {
                    var pop = stack.Pop();
                    if (!parenthesesMatch[parentheses].Equals(pop))
                    {
                        return false;
                    }
                }
            }


            return true;
        }
    }
}