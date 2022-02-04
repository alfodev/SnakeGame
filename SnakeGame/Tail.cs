using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Tail : Player
    {
        int TailX;
        int TailY;
        public char Appearance;
        public ConsoleColor color = ConsoleColor.White;


        public Tail(GameObject player, char appearance) 
            : base(appearance)
        {
            TailX = player.position.X;
            TailY = player.position.Y;  
            
            // this.TailDirection = MyDirection;
            // color = player.color;
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
