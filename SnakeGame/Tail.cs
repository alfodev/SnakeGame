using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Tail : Player
    {
        
        public char Appearance;
        public ConsoleColor color = ConsoleColor.White;


        public Tail(char appearance) 
            : base(appearance)
        {
            position.X = base.position.X;
            position.Y = base.position.Y;  
            
            // this.TailDirection = MyDirection;
            // color = player.color;
            this.Appearance = appearance;
        }
        public override void Update()
        {
            position.X = base.position.X-1;
            position.Y = base.position.Y+1;
        }
        public override void AteFood()
        {
            

        }
    }
}
