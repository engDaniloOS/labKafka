using LabKafkaConsumer.Domain.Models;
using LabKafkaConsumer.Domain.Providers;
using LabKafkaConsumer.Domain.UseCases;

namespace LabKafkaConsumer.Domain
{
    public class ProcessarProposta(IPropostaWriteRepository propostaWriteRepository) : IProcessarPropostaUseCase
    {
        public async Task Execute(Proposta proposta)
        {
			try
			{
				await propostaWriteRepository.SaveProposta(proposta);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro ao processar a proposta. Erro: {ex.Message}");
			}
        }
    }
}
