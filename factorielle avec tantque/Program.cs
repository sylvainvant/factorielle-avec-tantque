using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorielle_avec_tantque
{
    class Program
    {
        static void Main(string[] args)
        {
          // N est l'égale du compteur
         double N=0;
         string saissie;
         double resultat=1;
         //etapes:
            Console.WriteLine("entrez la valeur n a calculer:");
        
            saissie = Console.ReadLine();
            N = Convert.ToDouble(saissie);
           


            if (N==0 | N==1)
            {
                Console.WriteLine("La factorielle de "+N+" avec tantque est :" + resultat);
            }
                else
                {

                while (N > 1) 
                    {
                    resultat = (resultat * N);
                    N = N - 1;
                    }
                Console.WriteLine("La factorielle de " + N + " avec tantque est :" + resultat);

            }
            // permet de conserver affichage consol

            Console.ReadLine();



        }
    }
}
