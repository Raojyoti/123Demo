using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Problems
{
    public class Display
    {
        public void DisplayName(string firstname, string lastname)
        {
            string fullname = firstname + lastname;
            Console.WriteLine("Fullname is {0}", fullname);
        }
        public void DisplayName(string text, string firstname, string lastname)
        {
            string fulltext = text + firstname + lastname;
            Console.WriteLine("Fullname with text is {0}", fulltext);
        }
        public void DisplayName(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Sum of two numbers is {0}", result);
        }
    }
}
