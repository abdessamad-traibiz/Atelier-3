using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;
        public CompteEpargne(Client client, MAD solde) : base(client,solde)
        {
            double tauxinteret;
            bool Res;
            do
            {
                Console.Write("Donnez un taux valide : \t");
                //TryParse : fonction pour traitement des erreurs de type booléen qui prends en paramètres (la chaine a convertir,ou on va la stocker)
                Res = double.TryParse(Console.ReadLine(), out tauxinteret);
            } while (tauxinteret <= 0 || tauxinteret >= 100 || !Res);
            this.TauxInteret = tauxinteret;
        }
        public void CalculInteret()
        {
            this.AjouterInteret(TauxInteret / 100);
        }
        public override void Consulter()
        {
            Console.WriteLine("Compte Epargne : ");
            base.Consulter();
            Console.WriteLine("Taux Interêt :" + this.TauxInteret);
        }
        public override bool Debiter(MAD Somme)//la redéfinition de la méthode débiter
        {
            if (this.MoitieSolde(somme))
            {
                return base.Debiter(Somme);
            }
            return false;
        }
    }
}
