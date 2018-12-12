using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Salle.Control
{
    class Client
    {
        public event EventHandler newClient;

        public Client()
        {
            Console.WriteLine("Clients");
        }

        public void randClient()
        {
            while (true)
            {
                Random alea = new Random();
                int newClient = alea.Next(100);    
                if (newClient == 9)
                {
                    arriveeClient();

                    MaitreHotel master = new MaitreHotel();

                }
            }
        }

        public void arriveeClient()
        {
            Console.WriteLine("arrive");
        }

        public String clientCommand(String[] d, String[] e, String[] p)
        {
            String command = "";

            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(7);

                command += e[i] + ",";
            }
            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(4);

                command += p[i] + ",";
            }
            for (int i = 0; i < 4; i++)
            {
                Random alea = new Random();
                int choix = alea.Next(6);

                command += d[i] + ",";
            }
            Console.WriteLine(command);
            return command;
        }

        public void clientEat()
        {

        }


    }
}
