using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Salle.Control
{
    class ChefRang
    {
        private static void Envoi(message message)
        {
            //Sérialisation du message en tableau de bytes.
            byte[] msge = Encoding.Default.GetBytes(message.e);
            byte[] msgp = Encoding.Default.GetBytes(message.p);
            byte[] msgd = Encoding.Default.GetBytes(message.d);
            byte[] msgn = Encoding.Default.GetBytes(message.N);


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
