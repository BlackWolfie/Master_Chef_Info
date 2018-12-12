using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Salle.Control
{
    class Serveur
    {

        public Serveur()
        {
            
        }

        public void preparationSalle()
        {

        }

        public void apportCouvert()
        {

        }

        public void apportRepas()
        {
            Console.WriteLine("Voici votre repas :) ");
            Client monClient = new Client();
            monClient.clientEat();
        }

        public void ramassage()
        {
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Je vais vous débarasser");
        }

    }


}
