using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameTest.Classe;
using MonoGameTest.Classe.Carte;

namespace MonoGameTest
{
    class MaCarte
    {
        public List<Dessinable> Carte = new List<Dessinable>();
        public ContentManager content;
       
        public MaCarte(ContentManager content)
        {
            this.content = content;
        }

        public void Draw(SpriteBatch sprit)
        {
            foreach (Dessinable element in Carte)
            {
                element.draw(sprit);
            }
            
        }


        public void CreateCarte(string URL)
        {
            int x = 0, y = 0;
            foreach ( String lignes in System.IO.File.ReadAllLines(URL))
            {
                foreach(char lettre in lignes)
                {
                    if( lettre == 'H')
                    {
                        Carte.Add(new Herbe(x, y, content));
                    }
                    else if(lettre == 'S') Carte.Add(new Sable(x, y, content));
                    x++;
                }
                y++;
                x = 0;
            }
        }
    }
}
