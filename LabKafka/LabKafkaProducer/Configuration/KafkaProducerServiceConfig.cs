using Confluent.Kafka;

namespace LabKafkaProducer.Configuration
{
    public static class KafkaProducerServiceConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration config)
        {
            var producerConfig = new ProducerConfig
            {
                BootstrapServers = config.GetSection("Kafka")["BootstrapServers"],
                ClientId = config.GetSection("Kafka")["ClientId"],
                Acks = Acks.All,
                MessageTimeoutMs = 1000,
                MessageSendMaxRetries = 2
            };

            var producer = new ProducerBuilder<string, string>(producerConfig).Build();

            services.AddSingleton(producer);
        }
    }
}
