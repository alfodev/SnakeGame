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
            foreach (var obj in world.ListOfGameObjects)
            {
                Console.ForegroundColor = obj.color;
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(obj.appearance);
            }

            Console.SetCursorPosition(53, 0);
            Console.WriteLine(world.Points);

            // TODO Rendera spelvärlden (och poängräkningen)
            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)
        }
        public void RenderBlank()
        {
            foreach (var obj in world.ListOfGameObjects)
            {
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(" ");
            }


        }
        public void RenderBorder()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("O");
                Console.SetCursorPosition(i, 20);
                Console.Write("O");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("O");
                Console.SetCursorPosition(50, i);
                Console.Write("O");
            }
         
        }
        public bool RendererGameOver()
        {
            return true;
        }
    }
}
