using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    class Rectangle : Point, ISquareCounting, IDisplayAllInformation
    {
        int Width;
        int Length;

        public Rectangle(string color, Visibility visibility, int width, int length) : base(color, visibility)
        {
            Width = width;
            Length = length;
        }
        public void Square()
        {
            Console.WriteLine($"Площадь прямоугольника = {Width*Length}");
        }
        public override void DisplayAllInformation()
        {
            Console.Write($"{Width} {Length}");
            base.DisplayAllInformation();
        }
    }
}
