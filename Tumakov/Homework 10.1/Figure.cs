using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    enum Visibility
    {
        Visible,
        Invisible
    }
    abstract class Figure : IChangeColor, IDisplayVisibility, IMoving, IDisplayAllInformation
    {
        string Color;
        Visibility Visibility;
        public Figure(string color, Visibility visibility)        
        {
            Color = color;
            Visibility = visibility;
        }
        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
        public void DisplayVisibility()
        {
            Console.WriteLine(Visibility);
        }

        public virtual void DisplayAllInformation()
        {
            Console.WriteLine($" {Color}, {Visibility}");
        }

        public void Moving()
        {

        }

    }
}
