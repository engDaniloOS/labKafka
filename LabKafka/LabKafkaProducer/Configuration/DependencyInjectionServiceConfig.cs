using LabKafkaProducer.Domain;
using LabKafkaProducer.Domain.UseCases;

namespace LabKafkaProducer.Configuration
{
    public static class DependencyInjectionServiceConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IPublicarPropostaUseCase, PublicarProposta>();
        }
    }
}
