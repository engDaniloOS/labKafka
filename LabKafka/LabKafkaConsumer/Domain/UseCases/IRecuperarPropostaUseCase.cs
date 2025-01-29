using LabKafkaConsumer.Domain.Dtos;

namespace LabKafkaConsumer.Domain.UseCases
{
    public interface IRecuperarPropostaUseCase
    {
        Task<PropostaOutDto> Execute();
    }
}
