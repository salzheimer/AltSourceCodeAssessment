using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ledger.Data;

namespace Ledger.Services
{
    public class StartUp
    {
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<LedgerContext>(opt=>opt.UseInMemoryDatabase());
            
        }
    }
}
