using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Client
    {
        int id;
        string nom;
        string prenom;
        string adresse  ;
        public Client(int a , string b, string c,string e) 
        {
            id = a;
             nom=b ;
           prenom = c ;
            adresse = e;
        }

        public void Afficher()
        {
            Console.Write("Nom: " + this.nom + " ,Prenom: " + this.prenom + " ,Adresse: " + this.adresse);
        }
    }
}
