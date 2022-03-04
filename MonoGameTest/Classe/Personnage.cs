using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace MonoGameTest.Classe
{
    public class Personnage : IPersonnage
    {
        int sizeSprite = 40;
        public int x {get;set;}
        public int y { get; set; }
        private Texture2D texture2D;
        public Personnage(int x, int y, ContentManager content) 
        {
            texture2D = content.Load<Texture2D>("Personnage");
            this.x = x;
            this.y = y;
        }
        public void draw(SpriteBatch sprite)
        {
            sprite.Draw(texture2D, new Rectangle(x*sizeSprite, y*sizeSprite, 36, 50), new Rectangle(132, 36, 18, 25), Color.White);
        }

        public void déplacement(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }
}
