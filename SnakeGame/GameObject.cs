using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public abstract class GameObject
    {
        public Position position;

        // Utseende för objektet
        public char appearance; 


        public GameObject(char startAppearance)
        {
            this.appearance = startAppearance;
            position = new Position();       
        }
        public abstract void Update();
    }
}
