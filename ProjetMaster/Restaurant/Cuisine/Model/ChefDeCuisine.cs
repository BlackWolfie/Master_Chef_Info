using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Cuisine
{
    class ChefDeCuisine : WORKERS
    {
        private static Thread _thEcoute;
        public static ChefDePartie CDP = Program.CDP;

        public void Thread()
        {
            //Préparation et démarrage du thread en charge d'écouter.
            _thEcoute = new Thread(new ThreadStart(Ecouter));
            _thEcoute.Start();
        }

        private static void Ecouter()
        {
            //Console.WriteLine("Préparation à l'écoute...");

            //On crée le serveur en lui spécifiant le port sur lequel il devra écouter.
            UdpClient serveur = new UdpClient(5035);
            //creation liste de commande par table
            List<string> commande = new List<string>();
            string[] listage = new string[4];
            
            //Création d'une boucle infinie qui aura pour tâche d'écouter.
            while (true)
            {
                //Création d'un objet IPEndPoint qui recevra les données du Socket distant.
                IPEndPoint client = null;

                //On écoute jusqu'à recevoir un message.
                byte[] data = serveur.Receive(ref client);
                
                //Décryptage et affichage du message.
                string message = Encoding.Default.GetString(data);

                commande.Add(message);

                foreach (string command in commande)
                {
                    listage = command.Split(new char[] { ',' });
                }

                ReceptionCommande(listage);

                retournerCommande();
            }
        }

        public static void ReceptionCommande(string[] listage)
        {
            int i = 0;
            string Table = listage[0];

            foreach (string element in listage)
            {
                switch (i)
                {
                    case 1:
                        ChefDePartie.preparerEntree(element, Table);
                        break;
                    case 2:
                        ChefDePartie.preparerPlat(element, Table);
                        break;
                    case 3:
                        ChefDePartie.preparerDessert(element, Table);
                        break;
                }

                i++;
            }

        }

        public static void retournerCommande()
        {
            byte[] msge = Encoding.Default.GetBytes("Commande prête !");

            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5036);

            udpClient.Close();
        }
        
    }
}
