using System;

namespace CSles3
{
    class Program
    {
        static void Main(string[] args)
        {
            Room dungeon = new Room(100, 100);

            foreach  (Enemy enemy in dungeon.Enemies)
            {
                enemy.Logic();
            }
        }
    }
}
