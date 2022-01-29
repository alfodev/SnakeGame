using System;
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
        // Skapa variabel för nuvarande position

        public Player(Direction TheDirection)
        {
            // Skapa en default position för när användaren skapas
            this.MyDirection = TheDirection;
        }

        public override void Update(/*Variabel från main*/)
        {
            // Implementera metoden Update() så att den, beroende på spelarens riktning, flyttar sin position ett steg i rätt riktning.
            // om höger eller vänster
            // Position X = variabel från main
            // om upp eller ner
            // Position Y = variabel från main

        }
    }
}


