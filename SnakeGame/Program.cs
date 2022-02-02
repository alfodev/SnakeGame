using System;
using System.Threading;



namespace SnakeGame
{
    
    class Program
    {
        /// <summary>
        /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
        /// </summary>
        static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

        
        static void Loop()
        {
            // Initialisera spelet
            const int frameRate = 5;
            GameWorld world = new GameWorld();            
            ConsoleRenderer renderer = new ConsoleRenderer(world);

            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            Player karin = new(Direction.Down);
            Food mat = new();
            world.ListOfGameObjects.Add(karin);
            world.ListOfGameObjects.Add(mat);
            Console.WriteLine(mat.appearance);
            Console.WriteLine(mat.position.X);
            Console.WriteLine(karin.appearance);
            Console.WriteLine(karin.position.Y);
            // Huvudloopen 
            bool running = true;
            while (running)
            {
                Console.WriteLine("While");
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
                        break;

                    case ConsoleKey.DownArrow:
                        break;

                    case ConsoleKey.LeftArrow:
                        break;

                    case ConsoleKey.RightArrow:
                        break;

                    default: Console.WriteLine("default");
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
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            Console.WriteLine("Main");
            // Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt
            Loop();
        }
    }
}
