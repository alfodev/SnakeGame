﻿using System;
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
        public int frameRate = 4;
        

        /// <summary>
        /// A list containg the objects within the gameworld
        /// </summary>
        public List<GameObject> ListOfGameObjects = new List<GameObject>();

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
            foreach (var objects in ListOfGameObjects)
            {
                objects.Update();
                if (objects is Player)
                {
                    if (OutsideGameWorld(objects) == true)
                    {
                        Console.SetCursorPosition(20,10);
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
                                frameRate++;
                            }
                        }                
                    }
                }
            }
        }/// <summary>
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
