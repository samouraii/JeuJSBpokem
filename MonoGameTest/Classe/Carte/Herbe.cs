﻿
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameTest.Classe.Carte
{
    class Herbe : Dessinable, ISprit
    {
        public static char Lettre = 'H';
        private Texture2D texture2D;
        public Herbe(int x, int y, ContentManager content) :base(x,y)
        {
           texture2D = content.Load<Texture2D>("spritTerrain");
            
        }
        public override void draw(SpriteBatch sprit)
        {
            sprit.Draw(texture2D, new Rectangle(x* SizeSprit, y* SizeSprit, SizeSprit, SizeSprit), new Rectangle(36, 36, 14, 14), Color.White);
        }
    }
}
