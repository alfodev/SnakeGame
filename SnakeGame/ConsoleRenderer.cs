using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class ConsoleRenderer
    {
        private GameWorld world;
        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek
            

            this.world = gameWorld;
        }
        
        public void Render()
        {
            Console.SetCursorPosition(world.ListOfGameObjects[0].position.X, world.ListOfGameObjects[0].position.Y);
            Console.Write(world.ListOfGameObjects[0].appearance);
            Console.SetCursorPosition(world.ListOfGameObjects[1].position.X, world.ListOfGameObjects[1].position.Y);
            Console.Write(world.ListOfGameObjects[1].appearance);
            // TODO Rendera spelvärlden (och poängräkningen)

            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }
        public void RenderBlank()
        {
            Console.SetCursorPosition(world.ListOfGameObjects[0].position.X, world.ListOfGameObjects[0].position.Y);
            Console.Write(" ");
            Console.SetCursorPosition(world.ListOfGameObjects[1].position.X, world.ListOfGameObjects[1].position.Y);
            Console.Write(" ");
            
        }
    }
}
