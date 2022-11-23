using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        Texture2D dinoTexture;
        Texture2D KoopaTexture;
        Texture2D CasperTexture;
        Texture2D SquirrdulTexture;
        Texture2D backgroundTexture;
        Texture2D circleTexture;
        Rectangle circleRect;
        Texture2D rectangleTexture;
        Rectangle rectangleRect;
        SpriteFont TitleFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            circleRect = new Rectangle(950, 10, 40, 40);
            rectangleRect = new Rectangle(10, 10, 40, 40);
            _graphics.PreferredBackBufferWidth = 1000; 
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            KoopaTexture = Content.Load<Texture2D>("Koopa");
            SquirrdulTexture = Content.Load<Texture2D>("Sqirrdul");
            CasperTexture = Content.Load<Texture2D>("Casper");
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            TitleFont = Content.Load<SpriteFont>("TitleFont");
            backgroundTexture = Content.Load<Texture2D>("background");
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
            GraphicsDevice.Clear(Color.LightBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            //_spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, 1000, 800), Color.White);
           // _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White);
           // _spriteBatch.Draw(KoopaTexture, new Vector2(800, 600), Color.White);
           // _spriteBatch.Draw(SquirrdulTexture, new Vector2(600, 50), Color.White);
           // _spriteBatch.Draw(CasperTexture, new Vector2(10, 500), Color.White);
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.Red);
            _spriteBatch.Draw(circleTexture, circleRect, Color.Blue);
            _spriteBatch.DrawString(TitleFont, "John Higgs", new Vector2(300,100), Color.Pink);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}