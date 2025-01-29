using AutoMapper;
using Confluent.Kafka;
using LabKafkaProducer.Domain.Dtos;
using LabKafkaProducer.Domain.Models;
using LabKafkaProducer.Domain.UseCases;
using Newtonsoft.Json;

namespace LabKafkaProducer.Domain
{
    public class PublicarProposta(IProducer<string, string> producer, IMapper mapper, IConfiguration config) : IPublicarPropostaUseCase
    {
        private const int DIAS_LIMITE_PROPOSTA = 1;

        public async Task<PropostaOutDto> Executar(PropostaDto propostaDto)
        {
            try
            {
                var proposta = mapper.Map<PropostaDto, Proposta>(propostaDto);

                proposta.Id = Guid.NewGuid();
                proposta.Validade = DateTime.UtcNow.AddDays(DIAS_LIMITE_PROPOSTA);

                await PublicarMensagem(config, proposta);

                return mapper.Map<Proposta, PropostaOutDto>(proposta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao publicar mensagem", ex);

                return new PropostaOutDto
                {
                    HasError = true,
                    ErrorMessage = ex.Message
                };
            }
        }

        private async Task PublicarMensagem(IConfiguration config, Proposta proposta)
        {
            var jsonMessage = JsonConvert.SerializeObject(proposta);

            var kafkaMessage = new Message<string, string> { Value = jsonMessage };

            var topicName = config.GetSection("Kafka")["TopicName"];

            await producer.ProduceAsync(topicName, kafkaMessage);
        }
    }
}
