using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Direction { Up, Down, Left, Right }

namespace SnakeGame
{
    /// <summary>
    /// A class which contains information about the player. Direction,appearance and what happens if food is eaten. 
    /// </summary>
    /// <param name="Direction">Enum with four different values for the snakes direction.Up,down,left, right</param>
    /// <param name="Direction">Enum with four different values for the snakes direction.Up,down,left, right</param>
    /// <param name="Mydirection"> A field which get triggered by the keypress from the user</param>
    /// <returns>The movement of the snake and the outcome for when food is eaten</returns>
    public class Player : GameObject
    {
        public Direction MyDirection;
        
        public Player(Direction StartDirection, char appearance) : base(appearance)
        {
            // En default position skapas via GameObject klassen. Så vad behöver vi veta när vi skapar en ny player?
            // Vi vill bestämma utseende för våran spelare            
            // Vi vill att spelaren ska röra på sig direkt? Skall denna vara random eller bestämmas via konstruktorn?
            this.MyDirection = StartDirection;
        }

        /// <summary>
        ///  Detecting when the user is pressing a specific key on their keyboard,
        ///  which will move the snake in right direction
        /// </summary>
        /// <param name="Direction.Up"> An enum which moves the snake up</param>
        /// <param name="Direction.Down"> An enum which moves the snake down </param>
        /// <param name="Direction.Left">An enum which moves the snake to the left</param>
        /// <param name="Direction.Right">An enum which moves the snake to the right</param>
        /// <returns>Shifting the snakes direction according to chosen keypress</returns>
        public override void Update()
        {

            switch (MyDirection)
            {
                case Direction.Up:
                    position.Y -= 1;
                    break;
                case Direction.Down:
                    position.Y += 1;
                    break;
                case Direction.Left:
                    position.X -= 1;
                    break;
                case Direction.Right:
                    position.X += 1;
                    break;
                default:
                    break;
            }
            //Console.WriteLine("PLAYER UPDATE");
            // Position X = variabel från main
            // om upp eller ner
            // Position Y = variabel från main
        }
        public override void AteFood()
        {
            

        }


    }
}


