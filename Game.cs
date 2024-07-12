using IntoTheDiep.GameObjects;
using IntoTheDiep.Input;
using IntoTheDiep.Rendering;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IntoTheDiep.Core
{
    public class Game
    {
        private Renderer renderer;
        private InputHandler inputHandler;
        private List<GameObject> gameObjects;
        private bool isRunning;

        public Game(Renderer renderer, InputHandler inputHandler)
        {
            this.renderer = renderer;
            this.inputHandler = inputHandler;
            gameObjects = new List<GameObject>();
            isRunning = true;
        }

        public void Run()
        {
            Initialize();

            while (isRunning)
            {
                Update();
                Render();
            }
        }

        private void Initialize()
        {
            // Initialize game objects
            gameObjects.Add(new Player());
        }

        private void Update()
        {
            inputHandler.Update();

            foreach (var obj in gameObjects)
            {
                obj.Update(inputHandler);
            }

            // Simple input to quit game
            if (inputHandler.IsKeyPressed(Keys.Escape))
            {
                isRunning = false;
            }
        }

        private void Render()
        {
            renderer.Clear();

            foreach (var obj in gameObjects)
            {
                obj.Render(renderer);
            }

            renderer.Present();
        }
    }
}
