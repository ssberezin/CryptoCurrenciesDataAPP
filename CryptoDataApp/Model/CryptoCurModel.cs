using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDataApp.Model
{
    public class CryptoCurModel
    {
        public string? Name { get; set; }
        public string? Asset_id { get; set; }
        public decimal? Price { get; set; }
        public decimal? Volume_24h { get; set; }
        public double? Change_1h { get; set; }
        public double? Change_24h { get; set; }
        public double? Change_7d { get; set; }
    }

    public class Assets
    { 
        public Dictionary <string, CryptoCurModel> Items { get; set; }
    }


}
