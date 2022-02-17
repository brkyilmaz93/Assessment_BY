using Rise_Tech_Rehber.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model.IletisimBilgileri
{
    public class IletisimBilgileriResponse : BaseResponse
    {
        public IletsimBilgiItem Kayit { get; set; }
        public List<IletsimBilgiItem> Liste { get; set; }

    }

    public class IletsimBilgiItem : BaseItem
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bilgi içeriği alanı boş geçilemez.")]
        public string BilgiIcerigi { get; set; }
        public bool SilinmisMi { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "İletişim Tipi boş geçilemez.")]
        public int IT_ID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kisi Bilgisi Boş Geçilemez.")]
        public int UU_ID { get; set; }
    }
}
