using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    abstract class GameObject
    {
        public Position position;

        // Utseende för objektet
        public char appearance;


        public GameObject()
        {
            position = new Position();
            
        }
        public abstract void Update();
    }
}
