using Cuisine.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cuisine.Model
{
    abstract class Chef : WORKERS
    {
        private static Thread _thEcoute;
        public static ChefDePartie CDP = Program.CDP;
        private List<ISubscriber> _Subs = new List<ISubscriber>();

        public void Attach(ISubscriber subs)
        {
            _Subs.Add(subs);
        }

        public void Remove(ISubscriber subs)
        {
            _Subs.Remove(subs);
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
                Notify();
                commande.Add(message);

                foreach (string command in commande)
                {
                    listage = command.Split(new char[] { ',' });
                }
                foreach (string plat in listage)
                {
                    //Console.WriteLine(plat);
                }

                ReceptionCommande(listage);

                retournerCommande(listage[0]);
            }
        }

        public static void ReceptionCommande(string[] listage)
        {
        
            foreach (string element in listage)
            {
                ChefDePartie.preparerPlat(element);
            }

        }

        public static void retournerCommande(string table)
        {
            byte[] msge = Encoding.Default.GetBytes(table);

            UdpClient udpClient = new UdpClient();

            //La méthode Send envoie un message UDP.
            udpClient.Send(msge, msge.Length, "127.0.0.1", 5036);

            udpClient.Close();
        }

        public void Notify()
        {
            Console.WriteLine("Notified");
        }
    }
}
