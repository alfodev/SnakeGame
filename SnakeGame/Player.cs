using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Enum with four different values for the snakes direction. Up,down,left, right.
/// </summary>
public enum Direction { Up, Down, Left, Right }

namespace SnakeGame
{
    /// <summary>
    /// A class which contains information about the player. Direction,appearance and what happens if food is eaten. 
    /// </summary>
    public class Player : GameObject
    {
        public Direction MyDirection;
        
        public Player(char appearance) : base(appearance)
        {
            // En default position skapas via GameObject klassen. Så vad behöver vi veta när vi skapar en ny player?
            // Vi vill bestämma utseende för våran spelare            
            // Vi vill att spelaren ska röra på sig direkt? Skall denna vara random eller bestämmas via konstruktorn?
            this.MyDirection = Direction.Down;
        }

        /// <summary>
        ///  Detecting when the user is pressing a specific key on their keyboard,
        ///  which will move the snake in right direction
        /// </summary>
        public override void Update()
        {
            prevPosition.X = this.position.X;
            prevPosition.Y = this.position.Y;
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


