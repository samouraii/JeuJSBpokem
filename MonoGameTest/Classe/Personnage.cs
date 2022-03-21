using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace MonoGameTest.Classe
{
    public class Personnage : IPersonnage
    {
        int sizeSprite = 36;
        private Texture2D texture2D;
        private Vector2 mouvement;

        private bool saute = false, doubleSaute = false;

        public Personnage(int x, int y, ContentManager content) 
        {
            texture2D = content.Load<Texture2D>("Personnage");
            mouvement.X = x;
            mouvement.Y = y;
        }

        public bool CanSaute()
        {
            if (!saute || (!doubleSaute && !saute)) return true;
            return false;
         }

        public void AuSol()
        {
            saute = false;
            doubleSaute = false;
        }
        public void draw(SpriteBatch sprite)
        {
           // sprite.Draw(texture2D, new Rectangle(x*sizeSprite, y*sizeSprite, 36, 50), new Rectangle(132, 36, 18, 25), Color.White);
            sprite.Draw(texture2D,new Rectangle((int)mouvement.X, (int)mouvement.Y,36,50), new Rectangle(132, 36, 18,25), Color.White);
            
        }

        public void déplacement(string direction)
        {
            int x = 0;
            int y = 0;
            switch (direction)
            {
                case "droite":
                    x = 1;
                    break;

                case "gauche":
                    x = -1;
                    break;

                case "haut":
                    y = -1;
                    break;

                case "bas":
                    y = 1;
                    break;
            }
            mouvement.X += x * sizeSprite;
            mouvement.Y += y * sizeSprite;
        }
    }

    public enum DeplacementT
    {
        Droite = 1,
        Gauche = -1,
        Haut = 10,
        Bas = -10

    }
}
