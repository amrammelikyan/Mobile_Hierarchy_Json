using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public class IPhone_X : IPhone
    {
        public IPhone_X()
        {

        }
        public IPhone_X(DateTime releaseDate, RAM ram, Storage storage)
        {
            this.ReleaseDate = releaseDate;
            this.RAM = ram;
            this.Storage = storage;
        }
        public override string Name { get { return "IPhone X"; } }
        public override DateTime ReleaseDate { get; set; }
        public override RAM RAM { get; set; }
        public override Storage Storage { get; set; }
        public override string CPU { get { return "A11 Bionic + M11"; } }
        public override int Battery { get { return 2716; } }
        public override int RearCamera { get { return 24; } }
        public override int FrontCamera { get { return 12; } }
        public override int Weight { get { return 174; } }
        public override Dimensions Dimensions { get { return new Dimensions(143.6, 70.9, 7.7); } }
    }
}
