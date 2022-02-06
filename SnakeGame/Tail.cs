using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Tail : GameObject
    {

        public char Appearance;
        


        public Tail(char appearance,int posX,int posY) 
            : base(appearance,posX,posY)
        {
            color = ConsoleColor.DarkYellow;
            this.Appearance = appearance;
        }
        public override void Update()
        {

        }
        public override void AteFood()
        {
            

        }
    }
}
