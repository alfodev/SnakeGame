using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{   /// <summary>
    /// The "template" for the food and snake.
    /// </summary>
    public abstract class GameObject
    {
        public Position position;

        // Utseende för objektet
        public char appearance;
        public ConsoleColor color = ConsoleColor.White;

        public GameObject(char startAppearance)
        {
            this.appearance = startAppearance;
            position = new Position();       
        }

        public abstract void Update();
        public abstract void AteFood();
    }
}
