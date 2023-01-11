using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDataApp.Model.Helper
{
    public class APIHalper
    {
        public static HttpClient APIClient { get; set; }
        public static void InitClient()
        {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("");
            //APIClient.BaseAddress = new Uri("https://www.cryptingup.com/apidoc/");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
