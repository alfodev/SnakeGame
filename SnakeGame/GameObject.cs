using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    abstract class GameObject
    {
        public Position position = new Position();
        public char Appearance = '@';

        public abstract void Update();

    }
}
