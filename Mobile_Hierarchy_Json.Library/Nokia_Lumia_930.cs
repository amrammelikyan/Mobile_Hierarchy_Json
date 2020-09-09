using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public class Nokia_Lumia_930 : Nokia
    {
        public Nokia_Lumia_930(DateTime releaseDate, RAM ram, Storage storage)
        {
            this.ReleaseDate = releaseDate;
            this.RAM = ram;
            this.Storage = storage;
        }
        public override string Name { get { return "Nokia Lumia 930"; } }
        public override DateTime ReleaseDate { get; set; }
        public override RAM RAM { get; set; }
        public override Storage Storage { get; set; }
        public override string CPU { get { return "Adreno 330"; } }
        public override int Battery { get { return 2420; } }
        public override int RearCamera { get { return 20; } }
        public override int FrontCamera { get { return 2; } }
        public override int Weight { get { return 167; } }
        public override Dimensions Dimensions { get { return new Dimensions(137, 71, 9.8); } }
    }
}
