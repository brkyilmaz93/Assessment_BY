using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Rise_Tech_Rehber.Data;

namespace Rise_Tech_Rehber.Service.Services
{

    public class BaseService
    {
        protected RehberDbContext RehberDbContext { get; set; }
        protected readonly IServiceProvider ServiceProvider;
        public BaseService()
        {
            ServiceProvider = ServiceBuilder.Services.BuildServiceProvider();
            RehberDbContext = ServiceProvider.GetRequiredService<RehberDbContext>();
        }

    }
}
