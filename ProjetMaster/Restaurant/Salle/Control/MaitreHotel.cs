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
            appelChefRang();
        }
        
        public void accueilClient()
        {
            Console.WriteLine("CLient est arrivé");
        }

        public void appelChefRang()
        {
            ChefRang monChef = new ChefRang();
            monChef.installationClient();
        }
    }
}
