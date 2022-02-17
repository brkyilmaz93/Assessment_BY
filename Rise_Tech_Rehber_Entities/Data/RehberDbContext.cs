using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Data
{
    public class RehberDbContext : DbContext
    {
        public RehberDbContext()
        {

        }
        public RehberDbContext(DbContextOptions<RehberDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Kisi> KISILER { get; set; }
        public virtual DbSet<IletisimBilgisi> ILETISIMBILGILER { get; set; }
        public virtual DbSet<IletisimTip> ILETISIMTIPLER { get; set; }

      
    }
}

