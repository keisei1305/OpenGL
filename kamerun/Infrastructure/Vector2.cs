using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamerun.Infrastructure
{
    class Vector2
    {
        public float x,y;

        public Vector2()
        {
            this.y = 0;
            this.x = 0;
        }

        public Vector2(Vector2 vector2)
        {
            this.x = vector2.x;
            this.y = vector2.y;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

         public static Vector2 operator /(Vector2 vector, float digit)
        {
            return new Vector2(vector.x / digit, vector.y / digit);
        }
    }
}
