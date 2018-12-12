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

    class ChefRang
    {

        private static void Envoi(String message)
        {
            //Sérialisation du message en tableau de bytes.
            byte[] msge = Encoding.Default.GetBytes(message);

            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5035);

            udpClient.Close();
        }
        public ChefRang()
        {

        }
        public void Notify()
        {
            Console.WriteLine("Notified");
        }

        public void installationClient(int laTable)
        {
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Chef de rang : Je vous installe table " + laTable);
            distriCarte();
        }

        public void distriCarte()
        {
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Chef de rang : Voici la carte");
            priseCommande();
        }

        public void priseCommande()
        {
            String[] desserts = { "gaufres", "crepes", "tiramisu", "tartelette", "bavarois", "madeleine" };
            String[] entrees = { "feullete crabe", "oeuf cocotte", "gaspatcho", "paté", "tarte thon", "quiche", "foie gras" };
            String[] plat = { "soupe", "pates saumon", "blanquette", "poulet" };


            Client monCLient = new Client();

            String commande = monCLient.clientCommand(desserts, entrees, plat);
            Envoi(commande);

        }
        

        public void appelServeur()
        {

        }

    }
}
