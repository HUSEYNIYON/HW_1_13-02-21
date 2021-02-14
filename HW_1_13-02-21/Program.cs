using System;
using System.Collections.Generic;
using System.Threading;

namespace HW_1_13_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread SelectThread = new Thread(new ThreadStart(Client.Select));
            SelectThread.Start();
            SelectThread.Join();

        }
    }
}
