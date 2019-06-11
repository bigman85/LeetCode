using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bigman.LeetCodeSolution
{
    public class RegularExpressionMatching
    {
        public bool RunOne(string source, string expression)
        {
            List<ExpNode> expressions = new List<ExpNode>();
            for (int i = 0; i < expression.Length; i++)
            {
                var en = new ExpNode
                {
                    ch = expression[i],
                    tp = 1
                };
                if (i + 1 < expression.Length && expression[i + 1] == '*')
                {
                    en.tp = 0;
                }
                expressions.Add(en);
            }

            return Match(source, 0, expressions);
        }

        public bool Match(string source, int index, List<ExpNode> expressions)
        {
            var en = expressions[0];

            if (en.tp == 1)
            {
                if (en.ch == source[index] || en.ch == '.')
                {
                    return Match(source, index + 1, expressions.Skip(1).ToList());
                }
            }
            else
            {
                if (en.ch == source[index] || en.ch == '.')
                {
                    return Match(source, index + 1, expressions)
                    || Match(source, index + 1, expressions.Skip(1).ToList())
                    || Match(source, index, expressions.Skip(1).ToList());
                }
                else
                {
                    return Match(source, index, expressions.Skip(1).ToList());
                }
            }

            return false;
        }
    }

    public struct ExpNode
    {
        public char ch { get; set; }
        public int tp { get; set; }
    }
}