using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Data.Entity;

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

        public void installationClient()
        {
            Console.WriteLine("Je vous installe ici");
            distriCarte();
        }

        public void distriCarte()
        {
            Console.WriteLine("Voici la carte");
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

    }
}
