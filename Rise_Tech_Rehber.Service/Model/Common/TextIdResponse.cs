using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model.Common
{
    public class TextIdResponse : BaseResponse
    {
        public List<TextIdModel> Liste { get; set; }
    }
    public class TextIdModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }   
        [JsonProperty(PropertyName = "silinmismi")]
        public bool SilinmisMi { get; set; }
    }
}
