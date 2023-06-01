using Microsoft.Xna.Framework.Graphics;

namespace ZombieShooter.Core.Game.States
{
    public abstract class GameState
    {
        protected readonly Microsoft.Xna.Framework.Game Application;

        protected GameState(Microsoft.Xna.Framework.Game application) => Application = application;

        public abstract void Update(float deltaTime);

        public abstract void Draw(SpriteBatch  spriteBatch);
    }
}
