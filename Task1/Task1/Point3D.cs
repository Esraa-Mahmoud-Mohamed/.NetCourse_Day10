using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Point3D:IComparable, ICloneable
    {
        int x;
        int y;
        int z;


        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }
        public Point3D()
        {
            X = 0; Y = 0; Z = 0;
        }
        public Point3D(int _x, int _y, int _z)
        {
            X = _x; Y = _y; Z = _z;
        }

        public override string ToString() 
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(object obj)
        {
            Point3D point = (Point3D)obj;
            return this.X.CompareTo(point.X) !=0 ? this.X.CompareTo(point.X) : this.Y.CompareTo(point.Y);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
