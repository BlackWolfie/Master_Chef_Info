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
        private static void Envoi(Cuisine.Message message)
        {
            string entree = message.Entree;
            string plat = message.Plat;
            string dessert = message.Dessert;
            string numero = message.NTable;

            string concat = numero +"," + entree + "," + plat + "," + dessert;
            //Sérialisation du message en tableau de bytes.
            byte[] msge = Encoding.Default.GetBytes(concat);

            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5035);

            udpClient.Close();
        }
        public ChefRang()
        {
            Console.WriteLine("Bonjour Chef");
        }

        public void installationClient()
        {

        }

        public void distriCarte()
        {

        }

        public void priseCommande()
        {

        }

    }
}
