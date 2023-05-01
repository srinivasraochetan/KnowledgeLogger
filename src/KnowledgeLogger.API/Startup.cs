using KnowledgeLogger.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeLogger.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;    
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddDbContext<KnowledgeLoggerDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllers();
        }
    }
}
