using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_OOP_HW2
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            var buffer = new Stack<char>();

            for(int i = 0; i <str.Length;i++)
            {
                buffer.Push(str[i]);
            }
            return new string(buffer.ToArray());
        }
    }
}
