using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    abstract class GameObject
    {
        public Position position;
        public char appearance;

        public GameObject()
        {

        }
        public abstract void Update();

    }
}
