using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public class Xiaomi_Redmi_Note_9S : Xiaomi
    {
        public Xiaomi_Redmi_Note_9S(DateTime releaseDate, RAM ram, Storage storage)
        {
            this.ReleaseDate = releaseDate;
            this.RAM = ram;
            this.Storage = storage;
        }
        public override string Name { get { return "Xiaomi Redmi Note 9S"; } }
        public override DateTime ReleaseDate { get; set; }
        public override RAM RAM { get; set; }
        public override Storage Storage { get; set; }
        public override string CPU { get { return "Snapdragon 720G"; } }
        public override int Battery { get { return 5020; } }
        public override int RearCamera { get { return 73; } }
        public override int FrontCamera { get { return 16; } }
        public override int Weight { get { return 209; } }
        public override Dimensions Dimensions { get { return new Dimensions(165.8, 76.7, 8.8); } }
    }
}
