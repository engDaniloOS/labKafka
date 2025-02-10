using LabKafkaConsumer.Domain;
using LabKafkaConsumer.Domain.Providers;
using LabKafkaConsumer.Domain.UseCases;
using LabKafkaConsumer.Providers;

namespace LabKafkaConsumer.Configuration
{
    public static class DependencyInjectionServiceConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IProcessarPropostaUseCase, ProcessarProposta>();
            services.AddSingleton<IPropostaReadRepository, PropostaReadRepository>();

            services.AddTransient<IRecuperarPropostaUseCase, RecuperarProposta>();
            services.AddSingleton<IPropostaWriteRepository, PropostaWriteRepository>();
        }
    }
}
