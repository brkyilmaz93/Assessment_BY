using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Data
{
   public  class IletisimBilgisi
    {
        // Bu entity için Id --- IletisimBilgi_ID yerine kullanıldı
        [Key]
        public int Id { get; set; }
        // Bu entity için Id --- IletisimTip_ID yerine kullanıldı
        public string BilgiIcerigi { get; set; }
        public bool SilinmisMi { get; set; }
        [ForeignKey("IletisimTip")]
        public int IT_ID { get; set; }
        [ForeignKey("UU_ID")]
        public int UU_ID { get; set; }
        public virtual IletisimTip IletisimTip { get; set; }
    }
}
