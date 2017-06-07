using Ledger.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ledger.Services
{
    public class StartUp
    {
        public static void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<LedgerContext>(opt => opt.UseInMemoryDatabase());
        }
    }
}