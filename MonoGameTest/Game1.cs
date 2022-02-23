using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameTest.Classe.Carte;

namespace MonoGameTest
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        
        Texture2D targetSprit;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

          
           
            
        }
        MaCarte carte;
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 1400;
            _graphics.PreferredBackBufferWidth = 1400;
            _graphics.ApplyChanges();
            carte = new MaCarte(Content);
            
            carte.CreateCarte("Carte1.txt");
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            targetSprit = Content.Load<Texture2D>("osi");

            // TODO: use this.Content to load your game content here
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //dessiner la carte
            carte.Draw(_spriteBatch);
            //_spriteBatch.Draw(targetSprit,new Vector2(0,0),new Rectangle(0,0,15,15), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
