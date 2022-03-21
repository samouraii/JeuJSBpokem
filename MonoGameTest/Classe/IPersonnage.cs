using System;
using System.Collections.Generic;
using System.Text;
using MonoGameTest.Classe.Carte;

namespace MonoGameTest.Classe
{
    interface IPersonnage : ISprit
    {
        public void déplacement(string direction);
        public bool CanSaute();
        public void AuSol();
    }
}
