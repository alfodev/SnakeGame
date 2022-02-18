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
            VideoMode windowSize = new VideoMode((uint)(w.Width *
            SIZE), (uint)(w.Height * SIZE));
            string title = "Snake 2.0";
            window = new RenderWindow(windowSize, title);
            window.SetActive();
        }
        private void RenderBorder()
        {
            RectangleShape line = new RectangleShape();
            line.Size = new Vector2f(world.Width * SIZE, 1 * SIZE);
            line.Position = new Vector2f(0, 0);
            line.FillColor = Color.Yellow;
            window.Draw(line);

            line.Position = new Vector2f(0, world.Height * SIZE - SIZE);
            window.Draw(line);

            line.Size = new Vector2f(1 * SIZE, world.Width * SIZE);
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
                CircleShape cirkel = new CircleShape(SIZE);
                cirkel.FillColor = Color.Yellow;
                cirkel.Position = new SFML.System.Vector2f(obj.pos.X * SIZE, obj.pos.Y * SIZE);
                //Console.SetCursorPosition(obj.pos.X, obj.pos.Y);
                window.Draw(cirkel);
                //Console.Write(obj.appearance);
            }                        // TODO rita ut allting i world
            window.Display(); // Visa den nya framen i fönstret
        }
    }
}

