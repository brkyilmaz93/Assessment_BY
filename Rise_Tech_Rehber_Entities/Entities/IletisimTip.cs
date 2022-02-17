using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Data

{
    public  class IletisimTip
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TipAdı { get; set; }
        public bool SilinmisMi { get; set; }
        public virtual IletisimBilgisi IletisimBilgisi { get; set; }
    }
}
