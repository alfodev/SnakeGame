using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// A class which is providing information about the food. Color, positioning and outcome for when it is eaten.
    /// </summary>
    /// <param name="rnd1">represents the a random method which will generate a position for the food</param>
    public class Food : GameObject
    {
       
        public Food(char startAppearance) : base(startAppearance)
        {
          
        }
        Random rnd1 = new Random();
        
           
        public override void Update()
        {
            
        }

        /// <summary>
        /// A method which randomly selects colours for the food and points
        /// </summary>
        /// <param name="_random">represents the random class which later distribute a random color</param>
        /// <returns>returns the randomly genereted color</returns>
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(1,7));
            
            
        }
        /// <summary>
        /// The outcome for when the food is eaten. Random color is generated and a new random position is set
        /// </summary>
        /// <param name="color">represents the color for the food</param>
        /// <param name="position.X">represents the horizontally position of the food</param>
        /// <param name="position.y">represents the vertically position of the food</param>

        public override void AteFood()
        {
            

            position.X = rnd1.Next(3,48);
            position.Y = rnd1.Next(3, 18);


            color = GetRandomConsoleColor();






        }

    }
}
