using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Enum with four different values for the snakes direction. Up, down, left, right.
/// </summary>
public enum Direction { Up, Down, Left, Right }

namespace SnakeGame
{
    /// <summary>
    /// A class which contains information about the player. 
    /// Direction, position, appearance and what happens if food is eaten. 
    /// </summary>
    public class Player : GameObject
    {

        public Direction MyDirection;   
        /// <summary>
        /// Sets the color of the snakes head.
        /// The default direction when the game begin.
        /// </summary>
        /// <param name="posX">A constuct for the position horizontally.</param>
        /// <param name="posY">A construct for the position vertically.</param>
        /// <param name="headColor">The color of the snakes head.</param>
        public Player(char appearance,GameWorld world) : base(world)
        {
            
            base.appearance = appearance;
            color = ConsoleColor.Yellow;
            // En default position skapas via GameObject klassen. Så vad behöver vi veta när vi skapar en ny player?
            // Vi vill bestämma utseende för våran spelare            
            // Vi vill att spelaren ska röra på sig direkt? Skall denna vara random eller bestämmas via konstruktorn?
            this.MyDirection = Direction.Down;
        }


        /// <summary>
        ///  Detecting when the user is pressing a specific key on their keyboard,
        ///  which will move the snake in a specific direction.
        /// </summary>
        public override void Update()
        {
            switch (MyDirection)
            {
                case Direction.Up:               
                    pos.Y -= 1;                   
                    break;
                case Direction.Down:
                    pos.Y += 1;
                    break;
                case Direction.Left:
                    pos.X -= 1;
                    break;
                case Direction.Right:
                    pos.X += 1;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Makes the snake unable to turn in opposite direction.
        /// </summary>
        /// <param name="NextDirection">A method wich check the next direction of the snake</param>
        public void ChangeDirection(Direction NextDirection)
        {
            switch (NextDirection)
            {
                case Direction.Up:
                    if (MyDirection == Direction.Down) MyDirection = Direction.Down;
                    else MyDirection = Direction.Up;
                    break;
                case Direction.Down:
                    if (MyDirection == Direction.Up) MyDirection = Direction.Up;
                    else { MyDirection = Direction.Down; }
                    break;
                case Direction.Left:
                    if (MyDirection == Direction.Right) MyDirection = Direction.Right;
                    else { MyDirection = Direction.Left; }
                    break;
                case Direction.Right:
                    if (MyDirection == Direction.Left) MyDirection = Direction.Left;
                    else { MyDirection = Direction.Right; }
                    break;
                default: 
                    break;
            }                


        }
    }
}


