using System;
using System.Windows.Forms;
using IntoTheDiep.Core;
using IntoTheDiep.Input;
using IntoTheDiep.Rendering;

namespace IntoTheDiep
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();

            Renderer renderer = new Renderer(this);
            InputHandler inputHandler = new InputHandler(this);
            game = new Game(renderer, inputHandler);

            var gameThread = new System.Threading.Thread(game.Run);
            gameThread.Start();
        }
    }
}
