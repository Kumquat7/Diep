using IntoTheDiep.Input;
using IntoTheDiep.Rendering;
using System.Drawing;
using System.Windows.Forms;

namespace IntoTheDiep.GameObjects
{
    public class Player : GameObject
    {
        public override void Update(InputHandler inputHandler)
        {
            // Update player logic
            if (inputHandler.IsKeyPressed(Keys.W))
                Position = new Point(Position.X, Position.Y - 5);
            if (inputHandler.IsKeyPressed(Keys.S))
                Position = new Point(Position.X, Position.Y + 5);
            if (inputHandler.IsKeyPressed(Keys.A))
                Position = new Point(Position.X - 5, Position.Y);
            if (inputHandler.IsKeyPressed(Keys.D))
                Position = new Point(Position.X + 5, Position.Y);
        }

        public override void Render(Renderer renderer)
        {
            renderer.DrawRectangle(Position, Size, Color.Blue);
        }
    }
}
