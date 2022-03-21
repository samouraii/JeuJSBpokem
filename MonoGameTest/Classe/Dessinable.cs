using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;


namespace MonoGameTest.Classe
{
    abstract class Dessinable
    {
        protected int SizeSprit = 40;
        public int x { get; set; }
        public int y { get; set; }
       
        
        public Dessinable(int x, int y )
        {
            this.x = x;
            this.y = y;
            
        }
        abstract public void draw(SpriteBatch sprite);
    }
}
