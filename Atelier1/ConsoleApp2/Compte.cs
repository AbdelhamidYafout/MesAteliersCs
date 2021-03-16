using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Compte
    {
        readonly int numcompte;
         Client  titulaire ;
        Mad solde;
        static int cpt ;
        static Mad plafond;
        
        static Compte ()
        {
            plafond = new Mad(3000);
            cpt = 0;
        }
        public void afficher()
        {
            Console.WriteLine(" le titulaire ");
            titulaire.Afficher();
            Console.Write(" solde: " );
            this.solde.afficher();
        }
        public Compte(Client tit,Mad s)
        {
            cpt++;
            numcompte = cpt;
      
            solde = s;
            titulaire = tit;
        }
        public bool Crediter(Mad s)
        {
            if( s.Verify() == true)
            {
                this.solde.Addition(s);
                return true;
            }
            return false;
                 
        }
        public bool Debiter(Mad s)
        {  if (s < Compte.plafond  )
            {  
                if (this.solde > s )
                {
                    this.solde = this.solde - s;
                    return true;
                }else {
                    Console.WriteLine("vsolde insuffisant ");
                    return false;
            }
            }
          else  {
                Console.WriteLine("vous avez depasse le plafond ");
            return false;
            }

        }
        public bool Verser(Compte c ,Mad s)
        {
            if (this.Debiter(s) && c.Crediter(s))
                return true;
            else return false;
        }

    }
}
