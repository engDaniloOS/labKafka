namespace LabKafkaConsumer.Domain.Dtos
{
    public record PropostaOutDto(bool HasError = false, string? ErrorMessage = null, List<PropostaDto>? Propostas = null);
}
