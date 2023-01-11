using CryptoDataApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


//https://www.youtube.com/watch?v=aWePkE2ReGw&ab_channel=IAmTimCorey
//29 min stoped
namespace CryptoDataApp.Model
{
    public  class DataLoadClass
    {
        public static async Task <CryptoCurModel> LoadCryptoCurencysData(int cryptCurNum = 0)//will change
        {
            string curID = "BTC";
            string url = "https://www.cryptingup.com/apidoc/" + curID;
            
            using (HttpResponseMessage response = await APIHalper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CryptoCurModel cryptoModel = await response.Content.ReadAsAsync<CryptoCurModel>();
                    return cryptoModel;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }


        }
    }
}
