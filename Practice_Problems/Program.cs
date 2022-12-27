using System;

namespace Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations obj = new Calculations();
            obj.Addition();
            obj.Subtraction();
            obj.Division();
            obj.Multiplication();
            VotingAge voting1 = new VotingAge();//dafault constructor called
            VotingAge voting = new VotingAge(18);//parameterized constructor called
        }
    }
}
