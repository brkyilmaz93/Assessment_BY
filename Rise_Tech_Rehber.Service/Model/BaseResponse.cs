using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model
{
    public class BaseResponse
    {
        [DefaultValue(true)] public bool Basarili { get; set; }
        public string HataMesaji { get; set; }

        public void SetError(string mesaj)
        {
            Basarili = false;
            HataMesaji = mesaj;
        }

        public void SetSuccess()
        {
            Basarili = true;
        }
    }
}
