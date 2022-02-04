using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
    
{   /// <summary>
    /// A class which providing positioning of the different objects
    /// </summary>
    /// <param name="X">Represents an integer with the information about positioning horizontally</param>
    /// <param name="Y">Represents an integer with the information about positioning vertically</param>
    /// <returns> Returns the values of positioning horisontally and vertically</returns>
    public class Position
    {
        public int X;
        public int Y;

      

        // Denna konstruktor kanske skall använda sig av en random metod.
        public Position(int startX, int startY)
        {
           X = startX;
           Y = startY; 

        }
        public Position()
        {
            X = 10;
            Y = 10;
        }
    }
}
