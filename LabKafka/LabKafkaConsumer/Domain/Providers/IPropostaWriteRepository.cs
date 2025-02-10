using LabKafkaConsumer.Domain.Models;

namespace LabKafkaConsumer.Domain.Providers
{
    public interface IPropostaWriteRepository
    {
        Task SaveProposta(Proposta proposta);
    }
}
