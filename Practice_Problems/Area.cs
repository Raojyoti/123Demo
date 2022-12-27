using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Problems
{
    public class Area
    {
        int area;
        public void Area_Square(int side)
        {
            area = side * side;
            Console.WriteLine("Area of square: " + area);
        }
    }
    public class Area1 : Area
    {
        double area;
        public void Area_Circle(double radius)
        {
            area = 3.14 * radius * radius;
            Console.WriteLine("Area of circle: " + area);
        }
    }
    public class Area2 : Area1
    {
        int area;
        public void Area_rectangle(int length, int width)
        {
            area = length * width;
            Console.WriteLine("Area of rectangle: " + area);
        }
    }
}
