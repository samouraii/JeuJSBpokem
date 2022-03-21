
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameTest.Classe.Carte
{
    class Rocher : Dessinable, ISprit
    {
        private Texture2D texture2D;
        public static char Lettre = 'G';
        public Rocher(int x, int y, ContentManager content) :base(x,y)
        {
           texture2D = content.Load<Texture2D>("spritTerrain");
            
        }
        public override void draw(SpriteBatch sprit)
        {
            sprit.Draw(texture2D, new Rectangle(x* SizeSprit, y* SizeSprit, SizeSprit, SizeSprit), new Rectangle(749, 154, 14, 14), Color.White);
        }
    }
}
