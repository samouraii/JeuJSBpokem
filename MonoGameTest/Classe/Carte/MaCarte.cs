using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameTest.Classe;
using MonoGameTest.Classe.Carte;
using System.Linq;

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
            List<Dessinable> element = new List<Dessinable>();
            var type = typeof(Dessinable);
            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p) && p.GetField("Lettre") != null && (char)p.GetField("Lettre").GetValue(null) =='S').ToArray();
          


            foreach ( String lignes in System.IO.File.ReadAllLines(URL))
            {
                foreach(char lettre in lignes)
                {
                    /*if (lettre == 'H')
                    {
                        Carte.Add(new Herbe(x, y, content));
                    }
                    else if (lettre == 'S') Carte.Add(new Sable(x, y, content));
                    else if (lettre == 'T') Carte.Add(new Terre(x, y, content));
                    */
                    types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => type.IsAssignableFrom(p) && p.GetField("Lettre") != null && (char)p.GetField("Lettre").GetValue(null) == lettre).ToArray();
                    if (types.Length > 0) { 
                        Object[] args = { x, y , content};
                        Carte.Add((Dessinable)Activator.CreateInstance(types[0],args ));
                    }
                    x++;
                }
                y++;
                x = 0;
            }
        }
    }
}
