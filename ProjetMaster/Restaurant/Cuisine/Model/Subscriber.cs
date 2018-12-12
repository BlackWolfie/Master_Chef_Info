using Cuisine.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine.Model
{
    class Subscriber : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Nitification");
        }
    }
}
