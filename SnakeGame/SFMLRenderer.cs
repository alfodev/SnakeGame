using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SnakeGame
{
    class SFMLRenderer
    {
        static private int SIZE = 10; // Storlek på varje ruta
        private GameWorld world; // Referens till GameWorld (som förut)
        private RenderWindow window; // Referens till det SFML-fönster som vi skapar
        public SFMLRenderer(GameWorld w)
        {
            world = w;
            VideoMode windowSize = new VideoMode((uint)(w.Width * SIZE +10), (uint)(w.Height * SIZE +10));
            string title = "Snake 2.0";
            window = new RenderWindow(windowSize, title);
            window.SetActive();
        }
        private void RenderBorder()
        {
            RectangleShape line = new RectangleShape();
            line.FillColor = Color.White;
            line.Position = new Vector2f(0, 0);
            line.Size = new Vector2f(world.Width * SIZE, 1 * SIZE);            
            window.Draw(line);

            line.Rotation = 0;
            line.FillColor = Color.White;
            line.Size = new Vector2f(1 * SIZE, world.Width * SIZE + 20);            
            window.Draw(line);

            line.FillColor = Color.White;
            line.Position = new Vector2f(world.Width * SIZE , 0 * SIZE);
            window.Draw(line);

            line.Rotation = 360;
            line.FillColor = Color.White;
            line.Position = new Vector2f(0 * SIZE, world.Height * SIZE);
            line.Size = new Vector2f(world.Width * SIZE, 1 * SIZE);  
            window.Draw(line);
        }
        public void Render()
        {   
            if (!window.IsOpen)
            {
                return;
            }

            window.Clear(); // Motsvarigheten till Console.Clear()
            RenderBorder();
            window.DispatchEvents(); // Vi säger att vi tagit emot all info vi behöver
            

            foreach (var obj in world.GameObj)
            {
                if (obj is Tail)
                {
                    CircleShape svans = new CircleShape(SIZE-3, 4);
                    svans.Position = new Vector2f(obj.pos.X * SIZE, obj.pos.Y * SIZE);
                    svans.FillColor = Color.Black;
                    svans.OutlineThickness = 1;
                    svans.OutlineColor = Color.Magenta;
                    window.Draw(svans);
                }
                if (obj is Player)
                {
                    CircleShape cirkel = new CircleShape(SIZE-5);                    
                    cirkel.FillColor = Color.Black;
                    cirkel.OutlineThickness = 2;
                    cirkel.OutlineColor = Color.Yellow;
                    cirkel.Position = new Vector2f(obj.pos.X * SIZE, obj.pos.Y * SIZE);
                    window.Draw(cirkel);
                }
                if (obj is Food)
                {
                    CircleShape mat = new CircleShape(SIZE- 3, 3);    
                    mat.Position = new Vector2f(obj.pos.X * SIZE, obj.pos.Y * SIZE);
                    mat.FillColor = Color.Red;
                    window.Draw(mat);
                }               
            }      
            window.Display(); // Visa den nya framen i fönstret
        }
    }
}

