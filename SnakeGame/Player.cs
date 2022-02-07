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
        /// <param name="appearance">The appearance of the snakes head.</param>
        /// <param name="posX">A constuct fot the position horizontally.</param>
        /// <param name="posY">A construct for the position vertically.</param>
        /// <param name="headColor">The color of the snakes head.</param>
        public Player(char appearance, int posX,int posY, ConsoleColor headColor) : base(appearance, posX, posY)
        {
            color = headColor;
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
        }
        /// <summary>
        /// Abstract method when the snake eats the food.
        /// </summary>
        public override void AteFood()
        {
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


