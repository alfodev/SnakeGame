﻿using System;
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
        }

        public void StartGame()
        {
            
            for (int i = 3; i > 0; i--)
            {
                Console.SetCursorPosition(world.Width/2, world.Height/2);
                Console.Write(i);
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(world.Width / 2, world.Height / 2);
            Console.Write("Good luck!");
            Thread.Sleep(500);
            Console.SetCursorPosition(world.Width / 2, world.Height / 2);
            Console.Write("               ");
        }
        public void RenderBlank()
        {
            foreach (var obj in world.ListOfGameObjects)
            {
                Console.SetCursorPosition(obj.position.X, obj.position.Y);
                Console.Write(" ");
            }


        }
        public void RenderScore()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(22, 22);
            Console.WriteLine($"Points: {world.Points}");

            
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
