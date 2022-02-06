using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class GameWorld
    {
        public int Width; // X
        public int Height; // Y
        public int Points = 0;
        public bool GameOver;
        public int frameRate = 4;
        public bool AteFood = false;




        /// <summary>
        /// A list containg the objects within the gameworld
        /// </summary>
        public List<GameObject> ListOfGameObjects = new List<GameObject>();
        int posX;
        int posY;
        public GameWorld(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// updating the gameworld depending on outcome. If food gets eaten, points and speed is added. If outside frame,game is over
        /// </summary>

        public void Update()
        {
            if (Points != 0)
            {
                for (int i = Points; i > 0; i--)
                {


                    ListOfGameObjects[i + 1].position.X = ListOfGameObjects[i].position.X;
                    ListOfGameObjects[i + 1].position.Y = ListOfGameObjects[i].position.Y;


                }
            }
            foreach (var item in ListOfGameObjects)
            {

                
                if(item == ListOfGameObjects[ListOfGameObjects.Count - 1])
                {
                    posX = item.position.X;
                    posY = item.position.Y;
                }
                item.Update();
            }



            foreach (var item in ListOfGameObjects)
            {




                if (item is Player)
                {
                    if (OutsideGameWorld(item) == true) //Lägga till CollideMetod istället? Med sin svans eller världen.
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine("Total points: " + Points);
                        Thread.Sleep(2000);
                        GameOver = true;
                    }

                    if (item.position.X == ListOfGameObjects[0].position.X && item.position.Y == ListOfGameObjects[0].position.Y)
                    {
                        Points++;
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
                ListOfGameObjects.Add(tail);
            }


            


        }

        
        
        /// <summary>
         /// Generating the speed for the snake object.
         /// </summary>
         /// <returns>The speed for the object</returns>
        public int GetFrameRate()
        {
            return frameRate;
        }

        /// <summary>
        /// Deciding whether the player is outside the gameworld or not
        /// <param name="player">Represents the player in the game</param>
        /// <returns>if true, player is outside gameworld, otherwise false and game continues</returns>
      
        public bool OutsideGameWorld(GameObject player)
        {
            //Console.WriteLine("Hej från menyn");
            if (player.position.X >= 50 || player.position.X <= 0)
            {
                return true;
            }
            if (player.position.Y >= 20 || player.position.Y <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
