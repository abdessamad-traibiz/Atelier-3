using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CompteCourant : Compte
    {
        private MAD Decouvert;
        private CarteBancaire cartebancaire; 
        public CompteCourant(Client client,MAD solde, MAD decouvert,CarteBancaire carteban) :base(client,solde)
        {
            this.Decouvert = decouvert;
            this.cartebancaire = carteban;
        }

        public override bool Debiter(MAD Somme)//la redéfinition de la méthode débiter
        {
            if (this.ComparerDecouvert(Somme,Decouvert) 
            {
                return base.Debiter(Somme);
            }return false;

            
        }
    }
}
