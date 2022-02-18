using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    /// <summary>
    /// Information of objects position,appearance and color.
    /// </summary>
    public abstract class GameObject
    {
        public Position pos;
        public char appearance;
        public ConsoleColor color;

        /// <summary>
        /// Constructor that gives object its appearance and instance of Position
        /// </summary>
        /// <param name="startAppearance">The char instance that represents objects appearance</param>
        /// <param name="posX">The int instance that represents objects position horizontally</param>
        /// <param name="posY">The int instance that represents objects position vertically</param>
        public GameObject(GameWorld world)
        {           
            pos = new Position(world);
        }
        public GameObject(int posX, int posY)
        {
            pos = new Position(posX, posY);
        }
        
        /// <summary>
        /// Abstract method for object
        /// </summary>
        public abstract void Update();

    }
}
