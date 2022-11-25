using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    class Point : Figure, IMoving, IChangeColor
    {
        public Point(string color, Visibility visibility) : base(color, visibility)
        {
        }
    }
}
