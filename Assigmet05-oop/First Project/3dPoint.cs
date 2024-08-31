using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmet05_oop.First_Project
{
    public class _3dPoint : IComparable<_3dPoint>, ICloneable
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

        #region operators overloadig
        public static bool operator ==( _3dPoint a, _3dPoint b)
        {
            return (a.X.Equals(b.X)) && (a.Y.Equals(b.Y)) && (a.Z.Equals(b.Z));
        }
        public static bool operator !=(_3dPoint a, _3dPoint b)
        {
            return !(a== b);
        }
        #endregion
        #region IComparable ad ICloneable 
        public int CompareTo(_3dPoint other)
        {
            if (other == null)
                return 1;

            if (X != other.X)
                return X.CompareTo(other.X);
            else
                return Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new _3dPoint(X, Y, Z);
        }
        #endregion
    }
}
