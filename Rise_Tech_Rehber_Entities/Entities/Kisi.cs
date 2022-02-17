using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Data
{
   public class Kisi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Firma { get; set; }

        public bool SilinmisMi { get; set; }
        public virtual List<IletisimBilgisi> IletisimBilgileri{ get; set; }

    }


  
}
