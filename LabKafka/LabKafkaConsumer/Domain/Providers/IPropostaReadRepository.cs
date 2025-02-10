using LabKafkaConsumer.Domain.Models;

namespace LabKafkaConsumer.Domain.Providers
{
    public interface IPropostaReadRepository
    {
        Task<List<Proposta>> GetPropostas();
    }
}
