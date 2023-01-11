using CryptoDataApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDataApp.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            APIHalper.InitClient();
        }
            

    }
}
