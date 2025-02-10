using LabKafkaConsumer.Configuration;
using LabKafkaConsumer.Domain.Models;
using LabKafkaConsumer.Domain.Providers;

namespace LabKafkaConsumer.Providers
{
    public class PropostaWriteRepository(Context context): IPropostaWriteRepository
    {
        public async Task SaveProposta(Proposta proposta)
        {
            await context.Propostas.AddAsync(proposta);

            await context.SaveChangesAsync();
        }
    }
}
