using System;
using System.Threading;

/*  Vi har:
 *      - Gett spelplanen väggar.
 *      - Spelaren har möjlighet att välja "huvud".
 *      - Hastigheten accelererar när ormen äter.
 *      - Gett ormen en svans som växer vid mat-intag, svansens färger beror på vad maten hade för färg.
 *      - Det blir GameOver när ormen går in i sig själv eller i väggarna.
 *      - Slumpvis färg och position för maten.   
 *
 *      Gruppmedlemmar: Alexander Forsberg, Sofia Hansson, Josefin Unefäldt, Karin Eurenius    */

namespace SnakeGame
{
    /// <summary>
    /// Contains all information about the game
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
        /// </summary>
        static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

        static char headAppearance = ' ';

        /// <summary>
        /// Gives player an option to choose the appearance for the snakes head. Allows player to play again if dead.
        /// </summary>
        public static void Menu()
        {
            
            char GetChar(string msg)
            {
                bool parseSuccess = false;
                char character = ' ';
                while (!parseSuccess)
                {
                    Console.Write(msg);
                    parseSuccess = char.TryParse(Console.ReadLine().ToUpper(), out character);
                }
                return character; 
            }
            headAppearance = GetChar("What appearance would you like? Symbol/Letter/Number: ");
            while (true)
            {
                Console.Clear();
                Loop();                
                Console.Clear();
                Console.SetCursorPosition(20, 0);
                Console.WriteLine("Game Over 4 you!");            
                if (GetChar("Would you like to play again ? (Y / N): ") == 'N') break;
            }
        }
        /// <summary>
        /// Loop where game is running
        /// </summary>
        static void Loop()
        {
            GameWorld world = new GameWorld(60, 30); // Select size for Game
            ConsoleRenderer renderer = new ConsoleRenderer(world);
            Food food = new Food('x', 15, 10);
            Player player = new Player(headAppearance,20,3,ConsoleColor.Yellow);                    
            world.ListOfGameObjects.Add(food);
            world.ListOfGameObjects.Add(player);

            renderer.StartGame();
            renderer.RenderBorder();

            bool running = true;
            while (running)
            {
                int frameRate = world.GetFrameRate();
                DateTime before = DateTime.Now;

                ConsoleKey key = ReadKeyIfExists();
                switch (key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;
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

                world.Update();
                renderer.Render();

                double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
                if (frameTime > 0)
                {
                    Thread.Sleep((int)frameTime);
                }

                renderer.RenderBlank();

                if (world.GameOver == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }

        /// <summary>
        /// Runs Menu and gameloop. Also a suggestion for how a menu could look if we were to further develop the game.
        /// </summary>
        static void Main(string[] args)
        {
            Menu();

            // Extra alternative

            //Console.WriteLine("\t\nSnackeGame");
            //Console.WriteLine("\t\n[1] - Spela");
            //Console.WriteLine("\t\n[2] - High score");
            //Console.WriteLine("\t\n[3] - Avsluta");
            //int input = int.Parse(Console.ReadLine());
            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine("\t\nVälj svårighetsgrad:");
            //        Console.WriteLine("\t\n[1] - Easy");
            //        Console.WriteLine("\t\n[2] - Medium");
            //        Console.WriteLine("\t\n[3] - Hard");
            //        int input2 = int.Parse(Console.ReadLine());
            //        switch (input2)
            //        {
            //            case 1:
            //                Console.WriteLine("\t\nVälj ett tecken som ett utseende");
            //                // 1 poäng för lätt
            //                string apperianceEasy = Console.ReadLine();
            //                Console.Clear();
            //                // Starta spelet
            //                break;
            //            case 2:
            //                Console.WriteLine("\t\nVälj ett tecken som ett utseende");
            //                string apperianceMedium = Console.ReadLine();
            //                Console.Clear();
            //                break;
            //            case 3:
            //                Console.WriteLine("\t\nVälj ett tecken som ett utseende");
            //                string apperianceHard = Console.ReadLine();
            //                Console.Clear();
            //                break;
            //            default:
            //                Console.WriteLine("\t\nVänligen välj en siffra!");
            //                Console.Clear();
            //                break;
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("\t\nHighscore");
            //        int highScore = 0; //highscore
            //        Console.Clear();
            //        break;
            //    case 3:
            //        // Avsluta
            //        break;
            //    default:
            //        Console.WriteLine("\t\nVänligen väl en siffra från menyn");
            //        Console.Clear();
            //        break;
            //}
        }
    }
}
