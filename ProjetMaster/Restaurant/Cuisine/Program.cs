using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cuisine.Controller;
using Cuisine.Model;

namespace Cuisine
{
    class Program
    {
        public static ChefDePartie CDP = new ChefDePartie();
        public static ChefDeCuisine CDC = new ChefDeCuisine();
        public static List<RECETTE> entreeQ;

        static void Main(string[] args)
        {
            CDC.Attach(new Subscriber());
            CDC.Thread();
        }
    }
}
