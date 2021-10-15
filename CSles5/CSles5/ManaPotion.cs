using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    class ManaPotion : Equipment
    {
        public override void Use()
        {
            base.Use();
            Console.WriteLine("*used ManaPotion*");
        }
    }
}
