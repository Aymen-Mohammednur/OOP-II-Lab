using System;
using System.Linq;

namespace C_Sharp_Basic
{
    public class Question62
    {
        public static void Q62()
        {
            string str = "p(rq)st";
            Console.WriteLine(ReverseRemoveParentheses(str));
        }

        public static string ReverseRemoveParentheses(string str)
        {
            int leftIndex = str.LastIndexOf('(');
            if (leftIndex ==  -1) {
                return str;
            }
            else {
                int rightIndex = str.IndexOf(')', leftIndex);

                return ReverseRemoveParentheses(
                    str.Substring(0, leftIndex) +
                    new string(str.Substring(leftIndex + 1, rightIndex - leftIndex - 1).Reverse().ToArray()) +
                    str.Substring(rightIndex + 1)
                );
            }
        }
    }
}