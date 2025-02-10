using LabKafkaConsumer.Configuration;
using LabKafkaConsumer.Domain.Models;
using LabKafkaConsumer.Domain.Providers;
using Microsoft.EntityFrameworkCore;

namespace LabKafkaConsumer.Providers
{
    public class PropostaReadRepository(Context context) : IPropostaReadRepository
    {
        public async Task<List<Proposta>> GetPropostas()
        {
            return await context.Propostas
                                .ToListAsync();
        }
    }
}
