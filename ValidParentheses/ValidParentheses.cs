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

            foreach (var parentheses in s)
            {
                if (leftParentheses.Contains(parentheses))
                {
                    stack.Push(parentheses);
                }

                if (rightParentheses.Contains(parentheses))
                {
                    char pop;
                    stack.TryPop(out pop);

                    if (!parenthesesMatch[parentheses].Equals(pop))
                    {
                        return false;
                    }
                }
            }


            return stack.Count == 0;
        }
    }
}