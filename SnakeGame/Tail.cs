﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Tail : Player
    {

        public char Appearance;
        //public ConsoleColor color = ConsoleColor.White;


        public Tail(char appearance) 
            : base(appearance)
        {

            this.Appearance = appearance;
        }
        public override void Update()
        {
            prevPosition.X = this.position.X;
            prevPosition.Y = this.position.Y;
        }
        public override void AteFood()
        {
            

        }
    }
}
