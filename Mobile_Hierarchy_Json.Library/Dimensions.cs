using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public class Dimensions
    {
        public Dimensions(double height, double width, double thickness)
        {
            this.Height = height;
            this.Width = width;
            this.Thickness = thickness;
        }
        public double Height { get; }
        public double Width { get; }
        public double Thickness { get; }
    }
}
