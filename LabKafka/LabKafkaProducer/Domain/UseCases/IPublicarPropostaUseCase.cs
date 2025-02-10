using LabKafkaProducer.Domain.Dtos;

namespace LabKafkaProducer.Domain.UseCases
{
    public interface IPublicarPropostaUseCase
    {
        Task<PropostaOutDto> Executar(PropostaDto propostaDto);
    }
}
