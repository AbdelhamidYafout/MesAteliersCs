
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Client p = new Client(1, "abdel", "yafout", "casa");
            Client p2 = new Client(2, "ahmed", "ahmed", "casa");
            Compte c = new Compte(p , new Mad(5000));
            Compte c2 = new Compte(p2, new Mad(8000));
            c2.Verser(c,new Mad(100));
            c.afficher();
            c2.afficher();
            Console.ReadKey();

        }
    }
}
