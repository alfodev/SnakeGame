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
        public Direction MyDirection;

        public Player(Direction TheDirection)
        {
            // En default position skapas via GameObject klassen. Så vad behöver vi veta när vi skapar en ny player?
            // Vi vill bestämma utseende för våran spelare
            this.appearance = '@';
            // Vi vill att spelaren ska röra på sig direkt? Skall denna vara random eller bestämmas via konstruktorn?
            this.MyDirection = TheDirection;
        }

        // beroende på spelarens knapptryckning riktning, flyttar position ett steg i rätt riktning
        // Kan inte ha en inparameter i metoden?.
        public override void Update()
        {
            Console.WriteLine("PLAYER UPDATE");
            // Position X = variabel från main
            // om upp eller ner
            // Position Y = variabel från main
        }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
}


