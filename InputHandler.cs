using System.Collections.Generic;
using System.Windows.Forms;

namespace IntoTheDiep.Input
{
    public class InputHandler
    {
        private HashSet<Keys> keysPressed;

        public InputHandler(Form form)
        {
            keysPressed = new HashSet<Keys>();

            form.KeyDown += (sender, e) =>
            {
                keysPressed.Add(e.KeyCode);
            };

            form.KeyUp += (sender, e) =>
            {
                keysPressed.Remove(e.KeyCode);
            };
        }

        public void Update()
        {
            // Update input state if needed
        }

        public bool IsKeyPressed(Keys key)
        {
            return keysPressed.Contains(key);
        }
    }
}
