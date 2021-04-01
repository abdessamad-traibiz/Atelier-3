using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Client
    { 
        private string Nom;
        private string Prenom;
        private string Adresse;
        public List<Compte> ListeComptes;

        public Client(string N, string P, string A)
        {
            this.Nom = N;
            this.Prenom = P;
            this.Adresse = A;
            this.ListeComptes = new List<Compte>();
        }
        public void Afficher()
        {
            Console.WriteLine($"Client : Nom : {this.Nom} Prénom : {this.Prenom} Adresse : {this.Adresse}");
            foreach (Compte C in ListeComptes)//boucle pour afficher les différents comptes du client
            {
                Console.WriteLine("La liste des comptes du client : ");
                C.Consulter();
            }
    }
        public void AffecterCompte(Compte C)//Méthode pour ajouter le compte a la liste des comptes
        {
            ListeComptes.Add(C);
        }
        public void AfficherListeComptes()//Méthode pour afficher la liste des comptes et opérations
        {
            Console.WriteLine($"Liste des comptes du client : {this.Nom} {this.Prenom}");
            foreach (Compte Cpt in ListeComptes)
            {
                Cpt.Consulter();
                Cpt.AfficherOperation();
            }
        }
        public override string ToString()
        {
            return this.Nom + " | " + this.Prenom + " | " + this.Adresse;
        }
    }

}

