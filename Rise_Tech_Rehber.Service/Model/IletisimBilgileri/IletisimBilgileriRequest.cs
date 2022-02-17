using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model.IletisimBilgileri
{
    public class IletisimBilgileriRequest
    {
        [JsonProperty(PropertyName = "IletisimBilgi_ID")]
        public int? ID { get; set; }
        [JsonProperty(PropertyName = "Ad")]
        public string Ad { get; set; }
        [JsonProperty(PropertyName = "kayit")]
        public IletsimBilgiItem Kayit { get; set; }

        [JsonProperty(PropertyName = "silinecekmi")]
        public bool SilinecekMi { get; set; }
    }
}
