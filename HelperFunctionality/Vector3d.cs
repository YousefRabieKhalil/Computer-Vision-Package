using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctionality
{
    public  class Vector3d
    {
        public  double X, Y, Z;
        public Vector3d()
        {
            X = Y = Z = 0;
        }
        public Vector3d(double x , double y , double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
