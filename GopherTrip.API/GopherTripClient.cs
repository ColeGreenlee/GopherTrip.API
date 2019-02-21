using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GopherTrip.API
{
    public class GopherTripClient
    {
        private static readonly HttpClient client = new HttpClient();
        string API_URL_BASE = "https://api.peaktransit.com/v5/index.php?app_id=_RIDER&controller=vehicle&action=list&agencyID=88&key=c620b8fe5fdbd6107da8c8381f4345b4";
        //= "https://api.peaktransit.com/v5/index.php?";
        
        string API_URL_APPID = "_RIDER";

        string API_URL_Controller = "vehicle";
        //eta, stop, route,shape, vehicle, avas, agency

        string API_URL_Action = "list";
        //Not sure what other actions exist at the moment
        string API_URL_AgencyID = "88";
        // Not sure what this does at the moment
        string API_URL_Key = "c620b8fe5fdbd6107da8c8381f4345b4";
        // Static API key that doesn't seem to change?



        string API_URL_FULL = "";


        public GopherTripClient()
        {
            this.API_URL_FULL = this.API_URL_BASE + "app_id=" + this.API_URL_APPID + "&controller=" + this.API_URL_Controller + "&action=" + this.API_URL_Action + "&agencyID=" + this.API_URL_AgencyID + "&key=" + this.API_URL_Key;
        }

        public async Task GetAPIUpdateAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync(this.API_URL_FULL);

            var msg = await stringTask;
            Console.Out.WriteLine(msg);
        }
    }
}
