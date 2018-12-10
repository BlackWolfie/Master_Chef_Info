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
            //Sérialisation du message en tableau de bytes.
            byte[] msge = Encoding.Default.GetBytes(message.Entree);
            byte[] msgp = Encoding.Default.GetBytes(message.Plat);
            byte[] msgd = Encoding.Default.GetBytes(message.Dessert);
            byte[] msgn = Encoding.Default.GetBytes(message.NTable);


            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5035);
            udpClient.Send(msgp, msgp.Length, "127.0.0.1", 5035);
            udpClient.Send(msgd, msgd.Length, "127.0.0.1", 5035);
            udpClient.Send(msgn, msgn.Length, "127.0.0.1", 5035);

            udpClient.Close();
        }
        public ChefRang()
        {

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
