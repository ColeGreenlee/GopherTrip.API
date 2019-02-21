using System;
using System.Threading;
using GopherTrip.API;
namespace GopherTrip.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            GopherTripClient gt = new GopherTripClient();
            while (true) {
                gt.GetAPIUpdateAsync();
                Thread.Sleep(5000);
                    }
        }
    }
}
