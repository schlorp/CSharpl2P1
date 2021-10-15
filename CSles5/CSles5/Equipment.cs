using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    abstract class Equipment : OnPickup
    {
        public virtual void Equip()
        {
            Console.WriteLine("Base");
        }
        public virtual void Use()
        {
        }
    }
}
