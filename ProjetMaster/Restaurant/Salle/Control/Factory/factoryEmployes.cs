using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle.Control.Factory
{
    class factoryEmployes
    {
        public factoryEmployes(int personnel)
        {
            arrivePersonnel(personnel);
        }

        public void arrivePersonnel(int employe)
        {
            switch (employe)
            {
                case 1:
                    ChefRang leChef = new ChefRang();
                    break;
                case 2:
                    MaitreHotel leMaitre = new MaitreHotel();
                    break;
                case 3:
                    Serveur leServeur = new Serveur();
                    break;
                case 4:
                    Commis leCommis = new Commis();
                    break;
                default:
                    break;
            }
        }
    }
}
