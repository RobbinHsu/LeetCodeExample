using System.Collections.Generic;
using System.Linq;

namespace ValidParentheses
{
    public class ValidParentheses
    {
        public bool GetOutput(string s)
        {
            var leftParentheses = new[] {'(', '{', '['};
            var rightParentheses = new[] {')', '}', ']'};

            var parenthesesMatch = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{'},
            };

            var stack = new Stack<char>();

            if (s.ToCharArray().Length == 1)
            {
                return false;
            }

            var firstTop = s.ToCharArray().FirstOrDefault();
            if (rightParentheses.Contains(firstTop))
            {
                return false;
            }

            foreach (var parentheses in s)
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