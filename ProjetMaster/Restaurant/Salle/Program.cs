﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Salle.Control;

namespace Salle
{
    class Program
    {
        public static Serveur s = new Serveur();
        static void Main(string[] args)
        {
            Lancement launching = new Lancement();
            s.Thread();
        }
    }
}
