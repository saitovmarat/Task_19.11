using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    class Circle : Point, ISquareCounting
    {
        int RadiusLength;
        public Circle(string color, Visibility visibility, int radiusLength) : base(color, visibility)
        {
            RadiusLength = radiusLength;
        }

        public void Square()
        {
            Console.WriteLine($"Площадь круга = {Math.PI * (RadiusLength ^ 2)}");
        }
        public override void DisplayAllInformation()
        {
            Console.Write(RadiusLength);
            base.DisplayAllInformation();
        }
    }
}
