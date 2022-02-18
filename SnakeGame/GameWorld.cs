using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

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
        public int frameRate { get; set; } = 4;
        public bool AteFood = false;
        int posX;
        int posY;
        public Tail tail;

        /// <summary>
        /// A list containing instances of gameobjects
        /// </summary>
        public List<GameObject> GameObj = new List<GameObject>();


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
                GameObj[i + 1].pos.X = GameObj[i].pos.X;
                GameObj[i + 1].pos.Y = GameObj[i].pos.Y;
            }

            foreach (var item in GameObj)
            {
                if (item == GameObj[GameObj.Count - 1])
                {
                    posX = item.pos.X;
                    posY = item.pos.Y;
                }

                item.Update();

                if (item is Player)
                {
                    CheckCollision(item);

                    if (item.pos.X == GameObj[0].pos.X && item.pos.Y == GameObj[0].pos.Y)
                    {
                        Points++;     
                        tail = new Tail(posX, posY, GameObj[0].color);
                        ((Food)GameObj[0]).AteFood(Width, Height);
                        
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
                GameObj.Add(tail);
            }
        }
        /// <summary>
        /// Generating the speed for the snake object
        /// </summary>
        /// <returns>Returns the speed for the snake object</returns>
        //public int GetFrameRate()
        //{
        //    return frameRate;
        //}

        /// <summary>
        /// Checking whether the player is outside the gameworld or not
        /// </summary>
        /// <param name="player">Represents the object snake in the game</param>
        public void CheckCollision(GameObject player)
        {
            if (player.pos.X >= Width) player.pos.X = 1;
            if (player.pos.X <= 0) player.pos.X = Width - 1;
            if (player.pos.Y >= Height) player.pos.Y = 1;
            if (player.pos.Y <= 0) player.pos.Y = Height-1;
            foreach (var item in GameObj)
                if (item is Tail && player.pos.Y == item.pos.Y && player.pos.X == item.pos.X)
                {
                    GameOver = true;
                }
        }
    }
}
