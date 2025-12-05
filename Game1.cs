using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_summative 
{
    enum Screen
    {
        FirstScreen,
        FieldScreen,
        LastScreen
    }
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;
        SpriteFont instructionText;

        MouseState mouseState;

        Texture2D firstBackgroundTexture, feildTexture, lastBackgroundTexture;

        Rectangle doubleJumpRect, horseRect, poleJumpRect, waterJumpRect;

        Texture2D doubleJumpTexture, horseTexture, poleJumpTexture, waterJumpTexture;

        Vector2 horseSpeed;

        Color firstBackground, feild, lastBackground;

        Color backColor;

        Screen screen;

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

            screen = Screen.FirstScreen;
            screen = Screen.FieldScreen;
            screen = Screen.LastScreen;

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

            instructionText = Content.Load<SpriteFont>("InsructionText");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (screen == Screen.FirstScreen)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                    screen = Screen.FieldScreen;
                _spriteBatch.Draw(firstBackground, window);
            }
            else if (screen == Screen.FieldScreen)
            {

            }
            else if (screen == Screen.LastScreen)
            {

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            if (screen == Screen.FirstScreen)
            {
                
            }
            else if (screen == Screen.FieldScreen)
            {
                _spriteBatch.Draw(horseTexture, horseRect, Color.White);
                _spriteBatch.Draw(doubleJumpTexture, doubleJumpRect, Color.White);
                _spriteBatch.Draw(waterJumpTexture, waterJumpRect, Color.White);
                _spriteBatch.Draw(poleJumpTexture, poleJumpRect, Color.White);
            }
            else if (screen == Screen.LastScreen)
            {

            }
            

            base.Draw(gameTime);
        }
    }
}
