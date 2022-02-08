using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{   
    /// <summary>
    /// A class that handles all the rendering in the console window.
    /// </summary>
    class ConsoleRenderer
    {
        private GameWorld world;

        public ConsoleRenderer(GameWorld gameWorld)
        {
            world = gameWorld;
            Console.SetWindowSize(world.Width+10, world.Height+10); 
        }
        /// <summary>
        /// Rendering the gameworld. Appearance and positioning of the different objects within the World.
        /// also checks for a gameover-condition.
        /// </summary>
        /// 
        public void Render()
        {
            foreach (var obj in world.ListOfGameObjects)
            {             
                Console.ForegroundColor = obj.color;
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(obj.appearance);
            }
            RenderScore(); 

            if (world.GameOver)
            {
                Console.SetCursorPosition(world.Width/2 - 15, world.Height / 2);
                Console.Write("Game Over 4 you!  ");
                Console.Write("Total points: " + world.Points);
                Thread.Sleep(3000);
            }
        }
        /// <summary>
        /// Countdown followed by a message to the user before the game begins.
        /// </summary>
        public void StartGame()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.SetCursorPosition(world.Width/2, world.Height/2);
                Console.Write(i);
                Thread.Sleep(500);
            }
            Console.SetCursorPosition(world.Width / 2, world.Height / 2);
            Console.Write("Good luck!");
            Thread.Sleep(500);
            Console.CursorVisible = false;
            Console.Clear(); 
        }
        /// <summary>
        /// prints out blank characters at all object positions to clear consolewindow.
        /// </summary>
        public void RenderBlank()
        {
            foreach (var obj in world.ListOfGameObjects)
            {
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(" ");
            }
        }
        /// <summary>
        /// Prints out the player's current score.
        /// </summary>
        public void RenderScore()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(world.Width/2 - 5, world.Height+2);
            Console.WriteLine($"Points: {world.Points}");
        }
        /// <summary>
        /// Draws a border for the game.
        /// </summary>
        public void RenderBorder()
        {
            string snake = "SNAKE";
            int stringPos = 0;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= world.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(snake[stringPos]);
                Console.SetCursorPosition(i, world.Height);
                Console.Write(snake[stringPos]);
                stringPos++;
                if (stringPos == 5) stringPos = 0;
            }
            stringPos = 0;
            for (int i = 0; i <= world.Height; i++)
            {
                
                Console.SetCursorPosition(0, i);
                Console.Write(snake[stringPos]);
                Console.SetCursorPosition(world.Width, i);
                Console.Write(snake[stringPos]);
                stringPos++;
                if(stringPos == 5) stringPos = 0;

            }   
        }
    }
}
