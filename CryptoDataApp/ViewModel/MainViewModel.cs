using CryptoDataApp.Model;
using CryptoDataApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDataApp.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection <CryptoCurModel> Assets { get; set; }
        public MainViewModel()
        {
            APIHalper.InitClient();
            ItinAssets();



        }

        private async void ItinAssets()
        {
            Assets = await DataLoadClass.LoadCryptoCurencysData();
        }


    }
}
