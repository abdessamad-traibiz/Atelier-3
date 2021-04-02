using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Operation
    {
        public static int Cpt = 0;
        public int NumOp;
        public DateTime DateOp;
        public string Libelle;
        public MAD Montant;
        public Operation(string libelle, MAD montant)
        {
            this.NumOp = ++Cpt;
            this.DateOp = DateTime.Now;
            this.Libelle = libelle;
            this.Montant = montant;
        }

        public void Afficher()
        {
            Console.Write($"Operation :  {DateOp.ToShortDateString()} | N° {NumOp} |{Libelle}  ");
            Montant.Afficher();
        }
    }
}
