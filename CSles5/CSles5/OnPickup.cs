using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    abstract class OnPickup
    {
        public virtual void HitByMouse(int x, int y)
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
    }
}
