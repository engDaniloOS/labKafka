using Microsoft.EntityFrameworkCore;

namespace LabKafkaConsumer.Configuration
{
    public static class DatabaseServiceConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration config)
        {
            var databaseName = config.GetSection("Database")["Name"];

            services.AddDbContext<Context>(
                opt => opt.UseInMemoryDatabase(databaseName!), ServiceLifetime.Singleton);
        }
    }
}
