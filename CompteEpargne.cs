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
        public CompteEpargne(Client cl, MAD s) : base(cl, s)
        {
            double taux;
            bool Res;
            do
            {
                Console.Write("Donnez un taux valide : ");
                //TryParse : fonction qui prends en paramètres (la chaine a convertir,ou on va stocker)
                Res = double.TryParse(Console.ReadLine(), out taux);
            } while (taux <= 0 || taux >= 100 || !Res);
            this.TauxInteret = taux;
        }
        public void CalculInteret()
        {
             this.AjouterInteret(TauxInteret / 100);
        }
        public override void Consulter()
        {
            Console.Write("Compte Epargne : ");
            base.Consulter();
            Console.WriteLine("Taux Interêt :" + this.TauxInteret);
        }
    }
}
