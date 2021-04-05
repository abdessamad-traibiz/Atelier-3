using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    abstract class Compte
    {
        private readonly int NumCpt;
        private static int Cpt = 0;
        private readonly Client Titulaire;
        private  MAD Solde;
        private static MAD plafond = new MAD(2000);
        public List<Operation> ListeOperations;


        /*un constructeur static ,pas niveau de visblite(prive,pub) , pas d'argument , sans this
        il sert a initialiser les attributs statics
        Exemple:
        static Compte()
        {
            //Cpt = 0;
            //plafond = new MAD(2000);
        }*/
        public Compte(Client cl, MAD md)//Cons avec param
        {
            this.NumCpt = ++Cpt;
            this.Titulaire = cl;
            this.Solde = md;    
            this.ListeOperations = new List<Operation>();
            //cl.ListeComptes.Add(this);
            Titulaire.AffecterCompte(this);
        }

        public virtual bool Crediter(MAD Somme)
        {
            MAD ValNull = new MAD(0);
            string Aug = "+";
            if (Somme > ValNull)
            {
                this.Solde += Somme;
                ListeOperations.Add(new Operation(Aug, Somme));
                return true;
            }
            Console.WriteLine("impossible de Créditer somme négatif !!!");
            return false;
        }
        public virtual bool Debiter(MAD Somme)
        {
            MAD ValNull = new MAD(0);
            string minus = "-";
            if (Somme > ValNull)
            {
                if (Solde>=Somme && plafond>=Somme)
                {
                    this.Solde -= Somme;
                    ListeOperations.Add(new Operation(minus, Somme));
                    return true;
                }
                else if (Somme > plafond)
                {
                    Console.WriteLine("Valeur superieur au plafond !!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Impossible solde insuffisant !!");
                    return false;
                }
            }
            Console.WriteLine("Impossible somme negatif !!");
            return false;
        }
        public bool Verser(Compte Cmpt, MAD Somme)
        {
            if (this.Debiter(Somme) == true)
            {
                Cmpt.Crediter(Somme);
                return true;
            }
            return false;
        }
        public void AjouterInteret(double interet)
        {
            MAD Res = this.Solde * interet;
            this.Crediter(Res);
        }
        public virtual void Consulter()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("le num est : " + this.NumCpt);
            Console.Write("le titulaire est : " + this.Titulaire);
            Console.Write("le solde est : ");
            this.Solde.Afficher();
            foreach (Operation o in ListeOperations)
            {
                o.Afficher();
            }
            Console.WriteLine("***********************************************");
        }
        public bool ComparerDecouvert(MAD somme,MAD decouvert)=>(this.Solde-somme)>decouvert;
        public void AfficherOperation()
        {
            if (ListeOperations.Count > 0)
            {
                Console.WriteLine("\nListe des operations");
                foreach (Operation operation in ListeOperations)
                {
                    operation.Afficher();
                }
                return;
            } 
            Console.WriteLine("\nAucune Opération à afficher !!");
        }

        public bool MoitieSolde(MAD somme)
        {
            return Solde.MoitieSolde(somme);
        }
    }
}
