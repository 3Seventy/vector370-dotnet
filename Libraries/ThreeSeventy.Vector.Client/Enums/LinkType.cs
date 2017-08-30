using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSeventy.Vector.Client
{
    public enum LinkType
    {
        /// <summary>
        /// Links are static and don't have any dynamic properties.
        /// </summary>
        Static = 0,

        /// <summary>
        /// Links contain some dynamic properties.
        /// </summary>
        Dynamic = 1
    }
}
