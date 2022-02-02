using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class GameWorld
    {
        public int Width = 50;
        public int Height = 30;
        public int Points = 0;
        


        public List<GameObject> ListOfGameObjects = new List<GameObject>();

        public GameWorld()
        {

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
