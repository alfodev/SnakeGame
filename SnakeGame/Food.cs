using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food : GameObject
    {
        
        public Food(char startAppearance) : base(startAppearance)
        {
          
        }
        Random rnd1 = new Random();
        
           
        public override void Update()
        {
            
        }

        
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        public override void AteFood()
        {
            

            position.X = rnd1.Next(1, 50);
            position.Y = rnd1.Next(1, 20);

            if (GetRandomConsoleColor() != ConsoleColor.Black)
            {
                color = GetRandomConsoleColor();
            }
            
            
            
            

        }

    }
}
