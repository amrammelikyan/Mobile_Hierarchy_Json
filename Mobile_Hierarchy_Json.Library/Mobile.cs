using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public abstract class Mobile
    {
        public abstract string Company { get; }
        public abstract string Name { get; }
        public abstract DateTime ReleaseDate { get; set; }
        public abstract OS OS { get; }
        public abstract RAM RAM { get; set; }
        public abstract Storage Storage { get; set; }
        public abstract string CPU { get; }
        public abstract int Battery { get; }
        public abstract int RearCamera { get; }
        public abstract int FrontCamera { get; }
        public abstract int Weight { get; }
        public abstract Dimensions Dimensions { get; }
    }
}
