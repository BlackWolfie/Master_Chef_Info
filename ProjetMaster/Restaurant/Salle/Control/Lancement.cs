using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Salle.Control
{
    public class Lancement
    {
        
        public Lancement()
        {

            Console.WriteLine("---- OUVERTURE DU RESTAURANT ----");
            Console.WriteLine(" ");
            installationSalle();

            Client launch = new Client();

            Thread randomise = new Thread(new ThreadStart(launch.randClient));
            randomise.Start();

            
        }
        

        public void installationSalle()
        {
            //Définition du nombre de Tables
            Table[] mesTables = new Table[32];

            //Creation des tables 2
            for(int i = 0; i < 10; i++)
            {
                mesTables[i] = new Table(2);
            }       
            //Création des tables de 4
            for (int i = 10; i < 20; i++)
            {
                mesTables[i] = new Table(4);
            }
            //Création des tables de 6
            for (int i = 20; i < 25; i++)
            {
                mesTables[i] = new Table(6);
            }
            //Création des tables de 8
            for (int i = 25; i < 30; i++)
            {
                mesTables[i] = new Table(8);
            }
            //Création des tables de 10
            for (int i = 30; i < 32; i++)
            {
                mesTables[i] = new Table(10);
            }
            
        }

        public void installationTables()
        {

        }
    }
}
