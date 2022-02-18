using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// Information of objects position,appearance.
    /// </summary>
    public class Tail : GameObject
    {
        /// <summary>
        /// Constructor that gives object its appearance and instance of Position
        /// </summary>
        /// <param name="appearance">The char instance that represents objects appearance</param>
        /// <param name="posX">The int instance that represents objects position horizontally</param>
        /// <param name="posY">The int instance that represents objects position vertically</param>
        public Tail(int posX, int posY, ConsoleColor c)
            : base( posX, posY)
        {
            appearance = 'x';
            this.color = c;
        }

        /// <summary>
        /// Abstract method for object
        /// </summary>
        public override void Update()
        {
        }
    }
}
