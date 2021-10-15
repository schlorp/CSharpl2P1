using System;

namespace CSles5
{
    class Program
    {
        static void Main(string[] args)
        {
            armor chestplate = new armor();
            weapon sword = new weapon();
            HealPotion HPpotion = new HealPotion();
            ManaPotion manaPotion = new ManaPotion();

            chestplate.Equip();
            sword.Equip();
            HPpotion.Use();
            manaPotion.Use();
        }
    }
}
