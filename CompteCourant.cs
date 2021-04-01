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
        public CompteCourant(Client client,MAD solde, MAD decouvert) :base(client,solde)
        {
            this.Decouvert = decouvert;
        }

        public override bool Debiter(MAD Somme)//la redéfinition de la méthode débiter
        {
            if (this.ComparerDecouvert(Somme,Decouvert))
            {
                return base.Debiter(Somme);
            }return false;

            
        }
    }
}
