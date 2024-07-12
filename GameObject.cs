using IntoTheDiep.Input;
using IntoTheDiep.Rendering;
using System.Drawing;

namespace IntoTheDiep.GameObjects
{
    public abstract class GameObject
    {
        public Point Position { get; set; }
        public Size Size { get; set; }

        public GameObject()
        {
            Position = new Point(0, 0);
            Size = new Size(50, 50);
        }

        public abstract void Update(InputHandler inputHandler);
        public abstract void Render(Renderer renderer);
    }
}
