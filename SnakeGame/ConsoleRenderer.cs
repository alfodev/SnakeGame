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
            this.world = gameWorld;
            // TODO Konfigurera Console-fönstret enligt världens storlek
            Console.SetWindowSize(world.Width+10, world.Height+10);
            Console.CursorVisible = false;

            
        }
        /// <summary>
        /// Rendering the gameworld. Appearance and positioning of the different objects within the World.
        /// </summary>
        public void Render()
        {

            foreach (var obj in world.ListOfGameObjects)
            {
                
                Console.ForegroundColor = obj.color;
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(obj.appearance);
            }
            
            Console.SetCursorPosition(22,22);
            Console.WriteLine($"Points: {world.Points}");

            
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
            for (int i = 0; i <= 50; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("O");
                Console.SetCursorPosition(i, 20);
                Console.Write("O");
            }
            for (int i = 0; i <= 20; i++)
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
