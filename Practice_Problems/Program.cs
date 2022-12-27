using System;

namespace Practice_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculations obj = new Calculations();
            obj.Addition();
            obj.Subtraction();
            obj.Division();
            obj.Multiplication();
            Console.WriteLine("------------------------------------------------");
            VotingAge voting1 = new VotingAge();//dafault constructor called
            VotingAge voting = new VotingAge(18);//parameterized constructor called
            Console.WriteLine("-----------------------------------------------------");
           Display display = new Display();
            display.DisplayName("Jyoti ", "Rao");
            display.DisplayName("Hello ", "Jyoti ", "Rao");
            display.DisplayName(25, 100);
            Console.WriteLine("-------------------------------------------------------");
           Employee2 emp = new Employee2();
            int Salary = emp.salary;
            int Bonus = emp.bonus;
            Console.WriteLine("Salary of employee: " + Salary);
            Console.WriteLine("Bonus of employee2: " + Bonus);
            Console.WriteLine("-------------------------------------------------------");
            Area2 obj1 = new Area2();
            obj1.Area_Square(5);
            obj1.Area_Circle(4);
            obj1.Area_rectangle(4, 5);
        }
    }
}
