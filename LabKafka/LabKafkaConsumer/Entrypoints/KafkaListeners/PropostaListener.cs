using Confluent.Kafka;
using LabKafkaConsumer.Domain.Models;
using LabKafkaConsumer.Domain.UseCases;
using Newtonsoft.Json;
using System.Diagnostics;

namespace LabKafkaConsumer.Entrypoints.KafkaListeners
{
    public class PropostaListener(
        IProcessarPropostaUseCase processarProposta,
        IConsumer<string, string> consumer,
        IConfiguration configuration) 
        : IHostedService
    {

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var topicName = configuration.GetSection("Kafka")["TopicName"];
            consumer.Subscribe(topicName);

            Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        var resultado = consumer.Consume(cancellationToken);

                        var stopWatch = new Stopwatch();
                        stopWatch.Start();

                        await ProcessarMensagem(resultado);

                        stopWatch.Stop();
                        Console.WriteLine($"Processamento de mensagem realizado em {stopWatch.ElapsedMilliseconds}ms");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao processar a mensagem. Erro: {ex.Message}");
                    }
                }
            }, cancellationToken);

            return Task.CompletedTask;
        }

        private async Task ProcessarMensagem(ConsumeResult<string, string> resultado)
        {
            var message = resultado?.Message?.Value;

            if (message is null) return;

            var proposta = JsonConvert.DeserializeObject<Proposta>(message);

            await processarProposta.Execute(proposta!);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Finalizando consumo de tópico");
            return Task.CompletedTask;
        }
    }
}
