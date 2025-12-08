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

        //SpriteFont exitText, startText;

        MouseState mouseState;

        Texture2D firstBackgroundTexture, feildTexture, lastBackgroundTexture;

        Rectangle doubleJumpRect, horseRect, poleJumpRect, waterJumpRect, firstBackgroundRect, feildRect, lastBackgroundRect;

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
           

            horseRect = new Rectangle( 60, 370, 85, 210);
            poleJumpRect = new Rectangle(200, 440, 150, 150);
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
            mouseState = Mouse.GetState();
            this.Window.Title = mouseState.Position.ToString();

            if (screen == Screen.FirstScreen)
            {

                if (mouseState.LeftButton == ButtonState.Pressed)
                    screen = Screen.FieldScreen;
                
            }
            else if (screen == Screen.FieldScreen)
            {
                if (mouseState.RightButton == ButtonState.Pressed)
                    screen = Screen.LastScreen;
            }
            else if (screen == Screen.LastScreen)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                    Exit();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            if (screen == Screen.FirstScreen)
            {
                _spriteBatch.Draw(firstBackgroundTexture, window, Color.White);

                _spriteBatch.DrawString(instructionText, "Left Click To Start The Race!", new Vector2(), Color.White);
            }
            else if (screen == Screen.FieldScreen)
            {
                _spriteBatch.Draw(feildTexture, window, Color.White);

                _spriteBatch.Draw(horseTexture, horseRect, Color.White);
                _spriteBatch.Draw(doubleJumpTexture, doubleJumpRect, Color.White);
                _spriteBatch.Draw(waterJumpTexture, waterJumpRect, Color.White);
                _spriteBatch.Draw(poleJumpTexture, poleJumpRect, Color.White);
            }
            else if (screen == Screen.LastScreen)
            {
                _spriteBatch.Draw(lastBackgroundTexture, window, Color.White);
                _spriteBatch.DrawString(instructionText, "Congradulations,You Win!", new Vector2(), Color.White);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
