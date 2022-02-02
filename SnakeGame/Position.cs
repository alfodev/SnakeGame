using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Position
    {
        public int X;
        public int Y;

        //public int []? X;
        //public int []? Y;

        // Denna konstruktor kanske skall använda sig av en random metod.
        public Position()
        {
            this.X = 5;
            this.Y = 5;
        }
    }
}
