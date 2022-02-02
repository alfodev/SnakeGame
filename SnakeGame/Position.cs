using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
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
            X = 25;
            Y = 25;
        }
    }
}
