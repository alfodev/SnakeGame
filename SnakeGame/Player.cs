using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Direction { Up, Down, Left, Right }

namespace SnakeGame
{
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

        // beroende på spelarens knapptryckning riktning, flyttar position ett steg i rätt riktning
        // Kan inte ha en inparameter i metoden?.
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


