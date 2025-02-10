using Confluent.Kafka;
using LabKafkaConsumer.Entrypoints.KafkaListeners;

namespace LabKafkaConsumer.Configuration
{
    public static class KafkaConsumerServiceConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration config)
        {
            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = config.GetSection("Kafka")["BootstrapServers"],
                GroupId = config.GetSection("Kafka")["GroupId"],
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = true
            };
            
            var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();

            services.AddSingleton(consumer);
            services.AddHostedService<PropostaListener>();
        }
    }
}
