using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public abstract class IPhone : Mobile
    {
        public override string Company { get { return "Apple lnc."; } }
        public override OS OS { get { return OS.IOS; } }

    }
}
