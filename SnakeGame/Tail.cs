using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Tail : GameObject
    {
        public Tail(GameObject food, char Appearance) : base( Appearance)
        {
            position.X = food.position.X;
            position.Y = food.position.Y;
            appearance = Appearance;
        }
        public override void Update()
        {

        }
        public override void AteFood()
        {
            

        }
    }
}
