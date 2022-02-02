using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Food : GameObject
    {
        public Food(char startAppearance) : base(startAppearance)
        {
          
        }
        public override void Update()
        {
            //Console.WriteLine("FOOD UPDATE");

        }
    }
}
