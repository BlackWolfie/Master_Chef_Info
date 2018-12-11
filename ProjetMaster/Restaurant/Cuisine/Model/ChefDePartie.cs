using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine
{
    class ChefDePartie : WORKERS
    {
        public void PreparerIngredient()
        {

        }

        public static void preparerEntree(string entree, string Table)
        {
            Console.WriteLine(entree);
            Console.WriteLine(Table);
            using (var db = new ConnexionBDD())
            {
                var entreeQ = db.RECETTE
                                .Where(b => b.NOM_RECETTE == entree)
                                .ToList();
                entreeQ.ForEach(m => Console.WriteLine(m.NOM_RECETTE));

            }
        }
        public static void preparerPlat(string plat, string Table)
        {
            using (var db = new ConnexionBDD())
            {
                var PlatQ = db.RECETTE
                                .Where(b => b.NOM_RECETTE == plat)
                                .ToList();
                PlatQ.ForEach(m => Console.WriteLine(m.NOM_RECETTE));

            }
        }

        public static void preparerDessert(string dessert, string Table)
        {
            using (var db = new ConnexionBDD())
            {
                var DessertQ = db.RECETTE
                                .Where(b => b.NOM_RECETTE == dessert)
                                .ToList();
                DessertQ.ForEach(m => Console.WriteLine(m.NOM_RECETTE));

            }
        }

        public void OrdreCommis()
        {

        }
    }
    
}
