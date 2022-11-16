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
        Texture2D koopaTexture;
        Texture2D CasperTexture;
        Texture2D SquirldulTexture;
        Texture2D backgroundTexture;


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
            _graphics.PreferredBackBufferWidth = 1000; 
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            koopaTexture = Content.Load<Texture2D>("Koopa");
            SquirldulTexture = Content.Load<Texture2D>("Squirldul");
            CasperTexture = Content.Load<Texture2D>("Casper");
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
            GraphicsDevice.Clear(Color.SkyBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(koopaTexture, new Vector2(800, 600), Color.White);
            _spriteBatch.Draw(SquirldulTexture, new Vector2(600, 50), Color.White);
            _spriteBatch.Draw(CasperTexture, new Vector2(10, 500), Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}