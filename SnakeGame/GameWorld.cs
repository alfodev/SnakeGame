using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{/// <summary>
/// A class containing information about the lifespan of the snake. 
/// Information about when food is eaten and what happens when Crash in wall or itself.
/// </summary>
    public class GameWorld
    {
        public int Width; // X
        public int Height; // Y
        public int Points = 0;
        public bool GameOver;
        public int frameRate = 4;
        public bool AteFood = false;
        public ConsoleColor foodColor;
     
        /// <summary>
        /// A list containing the objects within the gameworld
        /// </summary>
        public List<GameObject> ListOfGameObjects = new List<GameObject>();
        int posX;
        int posY;

        /// <summary>
        /// Constructor that gives the area of the gameworld.
        /// </summary>
        /// <param name="width">The int instance that represents the width of the gameworld</param>
        /// <param name="height">The int instance that represents the height of the gameworld</param>
        public GameWorld(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Updating the gameworld depending on outcome.
        /// Whenever food is eaten,points is added,snake is growing and accelarating. Crash in wall or itself and the game is over.
        /// </summary>
        public void Update()
        {

                for (int i = Points; i > 0; i--)
                {
                    ListOfGameObjects[i + 1].position.X = ListOfGameObjects[i].position.X;
                    ListOfGameObjects[i + 1].position.Y = ListOfGameObjects[i].position.Y;
                }
            
            foreach (var item in ListOfGameObjects)
            {
                if (item == ListOfGameObjects[ListOfGameObjects.Count - 1])
                {
                    posX = item.position.X;
                    posY = item.position.Y;
                }
                
                item.Update();

                if (item is Player)
                {
                    CheckCollision(item);
                    if (GameOver)
                    {
                        Console.SetCursorPosition(19, Height/2);
                        Console.WriteLine("Total points: " + Points);
                        Thread.Sleep(5000);
                        GameOver = true;
                    }

                    if (item.position.X == ListOfGameObjects[0].position.X && item.position.Y == ListOfGameObjects[0].position.Y)
                    {
                        Points++;
                        foodColor = ListOfGameObjects[0].color;
                        ListOfGameObjects[0].AteFood();
                        AteFood = true;
                        frameRate++;
                    }
                    else
                    {
                        AteFood = false;
                    }
                }

            }
            if (AteFood)
            {

                Tail tail = new Tail('o', posX, posY);
                tail.color = foodColor;
                ListOfGameObjects.Add(tail);
            }
        }
        /// <summary>
        /// Generating the speed for the snake object
        /// </summary>
        /// <returns>Returns the speed for the snake object</returns>
        public int GetFrameRate()
        {
            return frameRate;
        }

        /// <summary>
        /// Checking whether the player is outside the gameworld or not
        /// </summary>
        /// <param name="player">Represents the object snake in the game</param>
        public void CheckCollision(GameObject player)
        {
            if (player.position.X >= 50 || player.position.X <= 0)
            {
                GameOver = true;
            }
            if (player.position.Y >= 20 || player.position.Y <= 0)
            {
                GameOver = true;
            }
            foreach (var item in ListOfGameObjects)
                if (item is Tail && player.position.Y == item.position.Y && player.position.X == item.position.X)
                {
                    GameOver = true;
                }
        }
    }
}
