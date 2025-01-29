using AutoMapper;
using LabKafkaProducer.Configuration;

namespace LabKafkaConsumer.Configuration
{
    public static class MapperServiceConfig
    {
        public static void Configure(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(config => config.AddProfile<MapperProfile>());
            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
