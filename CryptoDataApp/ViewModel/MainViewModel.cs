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
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection <Asset> AssetsCol { get; set; }

        private Asset selectedItemLeft;
        public Asset SelectedItemLeft

        {
            get { return selectedItemLeft; }
            set
            {
                if (selectedItemLeft != value)
                {
                    selectedItemLeft = value;
                    OnPropertyChanged(nameof(selectedItemLeft));
                }
            }
        }


        public  MainViewModel()
        {
            
            //ItinAssets();
            
           // Task.WaitAll(new Task[] { Task.Delay(2000) });
           //  string name = SelectedItemLeft.Name;
        }




        public async Task  ItinAssets()
        {
            APIHalper.InitClient();
            //AssetsCol = new ObservableCollection<Asset>();
            AssetsCol = await DataLoadClass.LoadCryptoCurencysData();
            SelectedItemLeft = AssetsCol[0];
        }


    }
}
