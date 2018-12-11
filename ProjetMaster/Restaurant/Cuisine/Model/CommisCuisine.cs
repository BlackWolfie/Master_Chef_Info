using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine
{
    class CommisCuisine : WORKERS
    {
        public void RecevoirOrdre()
        {

        }
        public static void retournerCommande()
        {
            byte[] msge = Encoding.Default.GetBytes("Commande prête !");

            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5036);

            udpClient.Close();
        }

        public void EplucherLegumes()
        {

        }

        public void RecupererIngredient()
        {

        }

        public void DonnerPlat()
        {

        }
    }
}
