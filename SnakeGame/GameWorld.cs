using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class GameWorld
    {
        public int Width; // X
        public int Height; // Y
        public int Points = 0;
        public bool GameOver;
        


        public List<GameObject> ListOfGameObjects = new List<GameObject>();

        public GameWorld(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public void Update()
        {
            foreach (var objects in ListOfGameObjects)
            {
                objects.Update();
                if (objects is Player)
                {
                    if (OutsideGameWorld(objects) == true)
                    {
                        Console.WriteLine("Total points: " + Points);
                        Thread.Sleep(2000);
                        GameOver = true;
                    }                    
                    
                    foreach (var objekt in ListOfGameObjects)
                    {
                        if (objekt is Food)
                        {
                            if (objekt.position.X == objects.position.X && objekt.position.Y == objects.position.Y)
                            {
                                objekt.AteFood();
                                Points++;
                            }
                        }                
                    }
                }
            }
        }

        public bool OutsideGameWorld(GameObject player)
        {
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
