using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Hierarchy.Library
{
    public abstract class Xiaomi : Mobile
    {
        public override string Company { get { return "Xiaomi Corporation"; } }
        public override OS OS { get { return OS.Android; } }
    }
}
