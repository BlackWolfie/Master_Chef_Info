using Cuisine.Controller;
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

        private static Thread _thEcoute;

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
        public void Thread()
        {
            //Préparation et démarrage du thread en charge d'écouter.
            _thEcoute = new Thread(new ThreadStart(Ecouter));
            _thEcoute.Start();
        }
        private void Ecouter()
        {
            //Console.WriteLine("Préparation à l'écoute...");

            //On crée le serveur en lui spécifiant le port sur lequel il devra écouter.
            UdpClient serveur = new UdpClient(5036);
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
                Notify();
                Console.WriteLine("Recu");


            }
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

        public void apporterCommande()
        {
            Console.WriteLine("Chef de rang : voici votre plat");

        }

        public void appelServeur()
        {

        }

    }
}
