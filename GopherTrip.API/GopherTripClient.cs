using Newtonsoft.Json;
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
        string API_URL_BASE = "https://api.peaktransit.com/v5/index.php?app_id=_RIDER&agencyID=88&key=c620b8fe5fdbd6107da8c8381f4345b4";
        
        public GopherTripClient()
        {
            
        }

        private async Task<string> REST_GET_Async(String controllerName, String actionName)
        {
            string requestURL = this.API_URL_BASE + "&controller=" + controllerName + "&action=" + actionName;
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            var stringTask = client.GetStringAsync(requestURL);

            var msg = await stringTask;
            return msg;
        }

        public async Task<VehicleResponse> GetVehicles()
        {
            return JsonConvert.DeserializeObject<VehicleResponse>(await REST_GET_Async("vehicle", "list"));
        }

        
    }
}
