﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Direction { Up, Down, Left, Right }
namespace SnakeGame
{
    internal class Player : GameObject
    {
        Direction MyDirection;
        public Player(Direction TheDirection)
        {
            MyDirection = TheDirection;
        }

        public override void Update()
        {

        }
    }
}


