using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamerun.Infrastruct
{
    internal class Point3d
    {
        public float x, y, z;
        public Point3d(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3d (Point3d point)
        {
            this.x = point.x;
            this.y = point.y;
            this.z = point.z;
        }
    }
}
