using System.Drawing;
using System.Windows.Forms;

namespace IntoTheDiep.Rendering
{
    public class Renderer
    {
        private Form form;
        private Graphics graphics;
        private Bitmap bitmap;

        public Renderer(Form form)
        {
            this.form = form;
            bitmap = new Bitmap(form.ClientSize.Width, form.ClientSize.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
        }

        public void DrawRectangle(Point position, Size size, Color color)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, new Rectangle(position, size));
            }
        }

        public void Present()
        {
            form.BackgroundImage = bitmap;
            form.Invalidate();
        }
    }
}
