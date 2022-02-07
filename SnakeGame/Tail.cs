using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// 
    /// </summary>
    public class Tail : GameObject
    {
        //public char Appearance;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appearance"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        public Tail(char appearance,int posX,int posY) 
            : base(appearance,posX,posY)
        {
            
            //this.Appearance = appearance;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Update()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void AteFood()
        {
        }
    }
}
