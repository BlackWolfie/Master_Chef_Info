using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Controller
{
    class SocketHandler : IObservable<ChefDeCuisine>
    {
        public IDisposable Subscribe(IObserver<ChefDeCuisine> observer)
        {

            throw new NotImplementedException();
        }
    }
}
