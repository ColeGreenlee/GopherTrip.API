using System;
using System.Threading;
using System.Threading.Tasks;
using GopherTrip.API;
namespace GopherTrip.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            GopherTripClient gt = new GopherTripClient();
            VehicleResponse v_list = await gt.GetVehicles();
            foreach (var v in v_list.VehicleList)
            {
                var time = v.NextStopEta;
                Console.Out.WriteLine(time);
                DateTime result = Util.ConvertFromUnixTimestamp(time);

                Console.WriteLine(v.VehicleName + ":" + result);
                
            }



            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    //Do nothing
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
