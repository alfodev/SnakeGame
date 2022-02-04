﻿using System;
using System.Threading;



namespace SnakeGame
{
    
    public class Program
    {
        /// <summary>
        /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
        /// </summary>
        static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;
        int frameRate = 5;
        
        static void Loop()
        {
            // Initialisera spelet
            
            GameWorld world = new GameWorld(50, 20);
            
            ConsoleRenderer renderer = new ConsoleRenderer(world);
            renderer.RenderBorder();
            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            Player karin = new('@');
            Food mat = new Food('¤');
            world.ListOfGameObjects.Add(karin);
            world.ListOfGameObjects.Add(mat);
            // Huvudloopen 
            bool running = true;
            while (running)
            {
                int frameRate = world.GetFrameRate();
                //Console.WriteLine("While");
                // Kom ihåg vad klockan var i början
                DateTime before = DateTime.Now;

                // Hantera knapptryckningar från användaren
                ConsoleKey key = ReadKeyIfExists();
                switch (key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;

                    // TODO Lägg till logik för andra knapptryckningar
                    case ConsoleKey.UpArrow:
                        karin.MyDirection = Direction.Up;                        
                        break;

                    case ConsoleKey.DownArrow:
                        karin.MyDirection = Direction.Down;
                        break;

                    case ConsoleKey.LeftArrow:
                        karin.MyDirection = Direction.Left;
                        break;

                    case ConsoleKey.RightArrow:
                        karin.MyDirection = Direction.Right;
                        break;

                    default: 
                        break;
                        
                    
                }

                // Uppdatera världen och rendera om
                world.Update();
                renderer.Render();
                

                // Mät hur lång tid det tog
                double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
                if (frameTime > 0)
                {
                    // Vänta rätt antal millisekunder innan loopens nästa varv
                    Thread.Sleep((int)frameTime);
                }

                renderer.RenderBlank();

                if(world.GameOver == true)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            // Döljer "pekaren" i konsolfönstret.

            //Console.WriteLine("Hej från menyn");
            //Console.WriteLine("[1] - Spela");
            //Console.WriteLine("[3] - Svårighetsgrad");
            //Console.WriteLine("[2] - High score");            
            //Console.WriteLine("[4] - Avsluta");
            //Console.ReadKey();
            //Console.WriteLine("Main");
            // Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt

            Loop();
            Console.Clear();
            Console.WriteLine("Game Over 4 you!");
            Console.ReadKey();  
        }
    }
}
