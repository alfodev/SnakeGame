using System;
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
            Player player = new Player('@',10,15);
            Food food = new Food('x',15,10);           
            world.ListOfGameObjects.Add(food);
            world.ListOfGameObjects.Add(player);
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
                        player.ChangeDirection(Direction.Up);
                        break;

                    case ConsoleKey.DownArrow:
                        player.ChangeDirection(Direction.Down);
                        break;

                    case ConsoleKey.LeftArrow:
                        player.ChangeDirection(Direction.Left);
                        break;

                    case ConsoleKey.RightArrow:
                        player.ChangeDirection(Direction.Right);
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

                if (world.GameOver == true)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            // Döljer "pekaren" i konsolfönstret.

            Console.WriteLine("\t\nSnackeGame");
            Console.WriteLine("\t\n[1] - Spela");
            Console.WriteLine("\t\n[2] - High score");
            Console.WriteLine("\t\n[3] - Avsluta");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("\t\nVälj svårighetsgrad:");
                    Console.WriteLine("\t\n[1] - Easy");
                    Console.WriteLine("\t\n[2] - Medium");
                    Console.WriteLine("\t\n[3] - Hard");
                    int input2 = int.Parse(Console.ReadLine());
                    switch (input2)
                    {
                        case 1:
                            Console.WriteLine("\t\nVälj ett tecken som ett utseende");
                            // 1 poäng för lätt
                            string apperianceEasy = Console.ReadLine();
                            Console.Clear();
                            // Starta spelet
                            break;
                        case 2:
                            Console.WriteLine("\t\nVälj ett tecken som ett utseende");
                            string apperianceMedium = Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("\t\nVälj ett tecken som ett utseende");
                            string apperianceHard = Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\t\nVänligen välj en siffra!");
                            Console.Clear();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\t\nHighscore");
                    int highScore = 0; //highscore
                    Console.Clear();
                    break;
                case 3:
                    // Avsluta
                    break;
                default:
                    Console.WriteLine("\t\nVänligen väl en siffra från menyn");
                    Console.Clear();
                    break;
            }
            //Console.WriteLine("Main");
            // Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt

            Loop();
            Console.Clear();
            Console.WriteLine("Game Over 4 you!");
            Console.ReadKey();
        }
    }
}
