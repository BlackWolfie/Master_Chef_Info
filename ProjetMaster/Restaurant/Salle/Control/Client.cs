using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Salle.Control
{
    class Client
    {

        public Client()
        {

        }

        public void randClient()
        {
            while (true)
            {
                Thread.Sleep(500);
                Random alea = new Random();
                int newClient = alea.Next(10);    
                if (newClient == 9)
                {
                    arriveeClient();

                    MaitreHotel master = new MaitreHotel();

                }
            }
        }

        public void arriveeClient()
        {
            Console.WriteLine("Clients : Bonjour nous sommes 4");
            System.Threading.Thread.Sleep(1000);
        }

        public String clientCommand(String[] d, String[] e, String[] p)
        {
            System.Threading.Thread.Sleep(1000);

            String command = "";
            Console.Write("Clients : Nous allons prendre : ");
            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(7);
                Console.Write(e[i] + " ");
                command += e[i] + ",";
            }
            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(4);
                Console.Write(e[i] + " ");
                command += p[i] + ",";
            }
            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(6);
                Console.Write(e[i] + " ");
                command += d[i] + ",";
            }
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);

            return command;
        }

        public void clientEat()
        {

        }


    }
}
