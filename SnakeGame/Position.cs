using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
    
{
    /// <summary>
    /// A class which providing positioning of the different objects
    /// </summary>
    public class Position
    {
        public int X;
        public int Y;


        /// <summary>
        /// providing positioning of the diffent objects 
        /// </summary>
        /// <param name="startX">Represents an integer with the information about positioning horizontally</param>
        /// <param name="startY">Represents an integer with the information about positioning vertically</param>

        // Denna konstruktor kanske skall använda sig av en random metod.
        public Position(int startX, int startY)
        {
           X = startX;
           Y = startY; 

        }
        public Position()
        {
            X = 10;
            Y = 12;
        }
    }
}
