using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public abstract class GameObject
    {
        public Position position;
        public Position prevPosition;
        // Utseende för objektet
        public char appearance;
        public ConsoleColor color;

        public GameObject(char startAppearance, int posX, int posY)
        {
            appearance = startAppearance;
            position = new Position(posX, posY);
        }
        
        public abstract void Update();
        public abstract void AteFood();
    }
}
