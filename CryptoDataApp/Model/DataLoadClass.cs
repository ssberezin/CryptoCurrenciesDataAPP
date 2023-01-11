using CryptoDataApp.Model.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.ComponentModel;


//https://www.youtube.com/watch?v=aWePkE2ReGw&ab_channel=IAmTimCorey
//29 min stoped
namespace CryptoDataApp.Model
{
    public  class DataLoadClass
    {
        

        public static async Task <ObservableCollection<CryptoCurModel>> LoadCryptoCurencysData()
        {
            
            string url = "https://cryptingup.com/api/assets?size=10";
            
            using (HttpResponseMessage response = await APIHalper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    //var responseBody = await  response.Content.ReadAsStringAsync();
                    var responseBody = await response.Content.ReadAsStringAsync();

                    

                    AllCrypto[] lst = JsonSerializer.Deserialize<AllCrypto[]>(responseBody); //  await response.Content.ReadAsAsync<List<CryptoCurModel>>();

                    ObservableCollection<CryptoCurModel> cryptoModelColl = new ObservableCollection<CryptoCurModel>(); ;
                    //foreach (var item in lst)
                    //{
                    //    cryptoModelColl.Add(item);
                    //}
                    return cryptoModelColl;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }


        }
    }
}
