
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    class Program
    {
      
        static void Main(string[] args)
        {
           
            bool ID_Existe;  

            // coucou Pascal
            List<Carrefour> unCarrefour = new List<Carrefour>()
          {
              new Carrefour(1, "Pâtes", 1.5, 500),
              new Carrefour(2, "Steak", 3, 800),
              new Carrefour(3, "Eau", 0.85, 1000),
              new Carrefour(4, "jambon", 2, 400)
          };
           
              foreach (Carrefour affiche in unCarrefour)
              {
                  Console.WriteLine(affiche);
              }

              for (int i = 0; i < unCarrefour.Count(); i++)
              {
                  Console.WriteLine("Quel est le numéro du produit ? ");
                  string valeur1 = Console.ReadLine();
                  int valeur = Convert.ToInt32(valeur1);
                 
                  ID_Existe = unCarrefour.Any(x => x.numero == valeur);

                  if (ID_Existe == true)
                  {
                      Console.WriteLine("Le produit existe.");
                  }
                  else
                  {
                      Console.WriteLine("le produit n'existe pas.");
                  }
              }



            Console.ReadLine();
        }
    }
}