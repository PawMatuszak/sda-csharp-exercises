using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoints
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public MyPoints(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}