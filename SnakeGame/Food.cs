using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// a class contating information about the food. Appearance and the outcome for when it is eaten
    /// </summary>
    public class Food : GameObject
    {
     
        public Food(char startAppearance) : base(startAppearance)
        {
          
        }

        /// <summary>
        /// randomly generating position
        /// </summary>
        Random rnd1 = new Random();
        
           
        public override void Update()
        {
            
        }

        /// <summary>
        /// randomly generating colors
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// A method which randomly selects colors for the food and points
        /// </summary>
        /// <returns>the randomly genereted color</returns>
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(1,7));
            
            
        }
        /// <summary> 
        /// The outcome for when the food is eaten. Random color is generated and a new random position is set
        /// </summary>
        public override void AteFood()
        {
            

            position.X = rnd1.Next(3,48);
            position.Y = rnd1.Next(3, 18);


            color = GetRandomConsoleColor();






        }

    }
}
