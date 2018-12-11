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
    class GetSocket
    {
        private static Thread thEcoute;
        public void Thread()
        {
            //Préparation et démarrage du thread en charge d'écouter.
            thEcoute = new Thread(new ThreadStart(Ecouter));
            thEcoute.Start();
        }
        private static void Ecouter()
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



                //if (message is string)
                //{
                //    apportRepas(message);
                //}
            }
        }
    }
}
