using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model.Kisi
{
    public class KisiRequest : BaseRequest
    {
  
        [JsonProperty(PropertyName = "kayit")]
        public KisiItem Kayit { get; set; }

    }
}
