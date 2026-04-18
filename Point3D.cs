using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public bool IsFirstOctantAndInteger()
        {
            bool isFirstOctant = X > 0 && Y > 0 && Z > 0;

            bool isInteger = (X % 1 == 0) && (Y % 1 == 0) && (Z % 1 == 0);

            return isFirstOctant && isInteger;
        }
    }
}
