using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle.Control
{
    class MaitreHotel
    {
        public MaitreHotel()
        {
            Client monCLient = new Client();

            Random alea = new System.Random();
            int laTable = alea.Next(10);
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Maitre d'hotel : Bienvenue :) la table " + laTable + " est libre, nous allons vous installer");
            appelChefRang(laTable);
        }
        
        public void accueilClient()
        {
            Console.WriteLine("CLient est arrivé");
        }

        public void appelChefRang(int laTable)
        {
            ChefRang monChef = new ChefRang();
            monChef.installationClient(laTable);
        }

        public void adieu()
        {
            Console.WriteLine("Maitre d'hotel : Bonne journée à vous");
        }
    }
}
