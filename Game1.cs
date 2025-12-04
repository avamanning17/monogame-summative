using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_summative 
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;
        SpriteFont introText, outroText;

        MouseState mouseState;

        Texture2D firstBackgroundTexture, feildTexture, lastBackgroundTexture;

        Rectangle doubleJumpRect, horseRect, poleJumpRect, waterJumpRect;

        Texture2D doubleJumpTexture, horseTexture, poleJumpTexture, waterJumpTexture;

        Vector2 horseSpeed;

        Color firstBackground, feild, lastBackground;

        Color backColor;

        screen screen;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            screen = firstBackground;
            screen = lastBackground;
            screen = feild;

            horseRect = new Rectangle();
            poleJumpRect = new Rectangle();
            doubleJumpRect = new Rectangle();
            waterJumpRect = new Rectangle();
            horseSpeed = new Vector2();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            horseTexture = Content.Load<Texture2D>("horse");
            poleJumpTexture = Content.Load<Texture2D>("poleJump");
            waterJumpTexture = Content.Load<Texture2D>("waterJump");
            doubleJumpTexture = Content.Load<Texture2D>("doubleJump");
            firstBackgroundTexture = Content.Load<Texture2D>("firstBackground");
            lastBackgroundTexture = Content.Load<Texture2D>("lastBackground");
            feildTexture = Content.Load<Texture2D>("feild");

            introText = Content.Load<SpriteFont>("firstBackground");
            outroText = Content.Load<SpriteFont>("lastBackground");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White;

            // TODO: Add your drawing code here

            _spriteBatch.Draw(horseTexture, horseRect, Color.White);
            _spriteBatch.Draw(doubleJumpTexture, doubleJumpRect, Color.White);
            _spriteBatch.Draw(waterJumpTexture, waterJumpRect, Color.White);
            _spriteBatch.Draw(poleJumpTexture, poleJumpRect, Color.White);

            base.Draw(gameTime);
        }
    }
}
