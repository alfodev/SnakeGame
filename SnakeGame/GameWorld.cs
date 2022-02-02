using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class GameWorld
    {
        public int Width; // X
        public int Height; // Y
        public int Points = 0;
        


        public List<GameObject> ListOfGameObjects = new List<GameObject>();

        public GameWorld(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Update()
        {
            foreach (var objects in ListOfGameObjects)
            {
                objects.Update(); 
            }
        }
    }
}
