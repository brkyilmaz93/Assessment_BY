using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rise_Tech_Rehber.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service
{
    public class ServiceBuilder
    {
        internal static ServiceCollection Services;
        public static ServiceCollection Build(string connectionString, string oldDbConnectionString = null)
        {
            Services = new ServiceCollection();
            Services.AddDbContext<RehberDbContext>(options =>
                      options.UseSqlServer(connectionString)
                 );
            return Services;
        }
    }
}
