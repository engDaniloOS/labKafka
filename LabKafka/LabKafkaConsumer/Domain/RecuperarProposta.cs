using AutoMapper;
using LabKafkaConsumer.Domain.Dtos;
using LabKafkaConsumer.Domain.Providers;
using LabKafkaConsumer.Domain.UseCases;

namespace LabKafkaConsumer.Domain
{
    public class RecuperarProposta(IPropostaReadRepository propostaRepository, IMapper mapper) : IRecuperarPropostaUseCase
    {
        public async Task<PropostaOutDto> Execute()
        {
			try
			{
                var propostas = await propostaRepository.GetPropostas();

                var propostasDto = mapper.Map<List<PropostaDto>>(propostas);

                return new PropostaOutDto { Propostas = propostasDto };
            }
			catch (Exception ex)
			{
                Console.WriteLine($"Erro ao recuperar as propostas: {ex.Message}");

                return new PropostaOutDto(true, ex.Message);
			}        
        }
    }
}
