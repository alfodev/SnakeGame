using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// A class contating information about the food. Appearance and the outcome for when it is eaten
    /// </summary>
    public class Food : GameObject
    {
        /// <summary>
        /// Constructor that gives object its appearance and instance of Position
        /// </summary>
        /// <param name="startAppearance">The char instance that represents objects appearance</param>
        /// <param name="posX"> The int instance that represents objects position horizontally</param>
        /// <param name="posY"> The int instance that represents objects position vertically</param>
        public Food(GameWorld world) : base(world)
        {
            base.appearance = 'x';
            color = GetRandomConsoleColor();
        }
 
        public override void Update() { }

        /// <summary>
        /// Randomly generating colors and position for the food object
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// A method which randomly selects colors for the food
        /// </summary>
        /// <returns>A randomly genereted color is given</returns>
        private ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor newColor = (ConsoleColor)consoleColors.GetValue(_random.Next(1, 7));
            while (color == newColor)
            {
                newColor = (ConsoleColor)consoleColors.GetValue(_random.Next(1, 7));
            }
            return newColor;  
        }
        /// <summary> 
        /// The outcome for when the food is eaten. Random color is generated and a new random position is set
        /// </summary>
        public void AteFood(int W, int H)
        {
            pos.X = _random.Next(3,W-2);
            pos.Y = _random.Next(3,H-2);
            color = GetRandomConsoleColor();
        }

    }
}
