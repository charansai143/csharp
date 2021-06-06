using System;
using System.Collections.Generic;
using System.Text;

namespace OopsApp
{
    //Base class
    public class Rectangle
    {
        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        protected int Length { get; set; }
        protected int Breadth { get; set; }
        public int CalculateArea()
        {
            return Length * Breadth;
        }
    }
    //Derived class
    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {

        }
        public string AccessRectangleProps()
            {
            return $"This Square has a side of dimension {Length} cm. The area of ths square is {CalculateArea()} ";
            }
    }
}