using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mad
    {    double valeur ;
    public void afficher()
        {
            Console.WriteLine(valeur + " MAD");
        }
        public  Mad (double a )
        {
            valeur = a; 
        }
        public double Addition(Mad d)
        {
            this.valeur += d.valeur;
            return this.valeur;
        }
           public static Mad operator -(Mad a ,Mad b )
        {
        Mad  x = new Mad(  a.valeur - b.valeur);
            return x;
        }
        public static Mad operator +(Mad a, Mad b)
        {
            Mad x = new Mad(a.valeur + b.valeur);
            return x;
        }
        
        public static bool operator >(Mad a, Mad b)
        {
            if (a.valeur > b.valeur)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(Mad a, Mad b)
        {
            if (a.valeur < b.valeur)
            {
                return true;
            }
            else 
                return false;
        }
        public double Soustraction(Mad d)
        {
          double a =  this.valeur - d.valeur;
            return a;
        }
      
        public bool Verify()
        {
            if (this.valeur > 0)
                return true;
            else return false;
        }
    }
}
