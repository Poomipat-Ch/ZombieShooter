using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ZombieShooter.Core.Game.States.ConcreteStates
{
    public class MainMenuState : GameState
    {

        public MainMenuState(Microsoft.Xna.Framework.Game application) 
            : base(application)
        {
        }

        public override void Update(float deltaTime)
        {
            UpdateInput(deltaTime);
        }

        private void UpdateInput(float deltaTime)
        {
            var keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.Escape))
                Application.Exit();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
