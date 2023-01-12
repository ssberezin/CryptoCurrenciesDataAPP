using CryptoDataApp.Model.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDataApp.Model
{
    public class Asset : ObservableObject
    {
        private string name;
        public string Name

        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }


        public string Asset_id { get; set; }
        public decimal Price { get; set; }
        public decimal Volume_24h { get; set; }
        public decimal Change_1h { get; set; }
        public decimal Change_24h { get; set; }
        public decimal Change_7d { get; set; }
        public decimal Market_cap { get; set; }
         
    }

    //public class Assets : ObservableObject
    //{
    //    public ObservableCollection<Asset> Items { get; set; }

    //}

    public class Root : ObservableObject
    {
        public ObservableCollection<Asset> Assets { get; set; }

    }


}
