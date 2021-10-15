using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    class weapon : Equipment
    {
        public override void Equip()
        {
            base.Equip();
            int damage = 10;
            Console.WriteLine("Damage: " + damage);
        }
    }
}
