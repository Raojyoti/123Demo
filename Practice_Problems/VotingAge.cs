using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Problems
{
    public class VotingAge
    {
        public VotingAge()//default constructor
        {
            Console.WriteLine("Required Age for voting is 18");
        }
        int requiredAge=18;
        public VotingAge(int userage)//parameterized constructor
        {

            if (userage >= requiredAge)
            {
                Console.WriteLine("Your are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting");
            }
        }
    }
}
