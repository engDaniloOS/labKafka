namespace LabKafkaConsumer.Domain.Dtos
{
    public class PropostaOutDto
    {
        public bool HasError { get; set; }
        public string? ErrorMessage { get; set; }
        public List<PropostaDto>? Propostas { get; set; }
    }
}
