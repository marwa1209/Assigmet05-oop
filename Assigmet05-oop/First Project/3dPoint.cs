using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmet05_oop.First_Project
{
    public class _3dPoint
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion
        #region Costructors
        public _3dPoint():this(0,0,0)
        {

        }
        public _3dPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})”.";
        }

    }
}
