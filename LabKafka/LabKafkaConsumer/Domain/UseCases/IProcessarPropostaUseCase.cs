using LabKafkaConsumer.Domain.Models;

namespace LabKafkaConsumer.Domain.UseCases
{
    public interface IProcessarPropostaUseCase
    {
        Task Execute(Proposta proposta);
    }
}
