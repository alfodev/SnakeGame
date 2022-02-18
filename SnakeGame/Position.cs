﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame    
{
    /// <summary>
    /// A class which providing positioning of the different objects.
    /// </summary>
    public struct Position
    {
        Random r = new Random();
        public int X;
        public int Y;
        /// <summary>
        /// Providing positioning of the diffent objects.
        /// </summary>
        /// <param name="startX">Represents an integer with the information about positioning horizontally</param>
        /// <param name="startY">Represents an integer with the information about positioning vertically</param>
        public Position(int startX, int startY)
        {
           X = startX;
           Y = startY; 
        }
        public Position(GameWorld world)
        {
            X = r.Next(5, world.Width - 5);
            Y = r.Next(5, world.Height - 5);
        }
    }
}
