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
        
        public static void preparerPlat(string plat)
        {
            using (var db = new ConnexionBDD())
            {
                var PlatQ = db.RECETTE
                                .Where(b => b.NOM_RECETTE == plat)
                                .ToList();
                PlatQ.ForEach(m => Console.WriteLine(m.NOM_RECETTE));

            }
        }
        

        public void OrdreCommis()
        {

        }
    }
    
}
