using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    class armor : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            int damageAbsorbtion = 100;
            Console.WriteLine("damage resistance: " + damageAbsorbtion);
        }

    }
}
