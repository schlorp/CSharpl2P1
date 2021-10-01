using System;
using System.Collections.Generic;
using System.Text;

namespace CSles3
{
    class Room
    {
        private int width;
        private int heigth;

        Tile[][] RoomTiles = new Tile[5][];
        public List<Enemy> Enemies = new List<Enemy>()
        {
            new Enemy(),
            new Enemy(),
            new Enemy(),
            new Enemy()
        };

       
        public Room(int _width, int _height)
        {
            width = _width;
            heigth = _height;

            for (int i = 0; i < RoomTiles.Length; i++)
            {
                RoomTiles[i] = new Tile[2];
                for (int y = 0; y < RoomTiles[i].Length; y++)
                {
                    RoomTiles[i][y] = new Tile();
                }
            }
        }



    }
}
