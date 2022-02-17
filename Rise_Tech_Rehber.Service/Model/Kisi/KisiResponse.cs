using Rise_Tech_Rehber.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Model.Kisi
{
    public class KisiResponse : BaseResponse
    {
        public KisiItem Kayit { get; set; }
        public List<KisiItem> Liste { get; set; }

    }

    public class KisiItem : BaseItem
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "İsim Alanı Boş Geçilemez.")]
        public string Ad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alanı Boş Geçilemez.")]

        public string Soyad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Firma Alanı Boş Geçilemez.")]
        public string Firma { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Aktiflik bilgisi Alanı Boş Geçilemez.")]
        public bool SilinecekMi { get; set; }
    }
}
