﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{

    using System;
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            Thread threadCal = new Thread(new ThreadStart(Functions.startConsoleInterface));
            threadCal.Start();
        }
    }
}
