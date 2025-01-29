using System.Text.Json.Serialization;

namespace LabKafkaConsumer.Domain.Dtos
{
    public record PropostaDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; init; }

        [JsonPropertyName("validade")]
        public DateTime Validade { get; init; }

        [JsonPropertyName("cliente")]
        public ClienteDto Cliente { get; init; }

        [JsonPropertyName("oferta")]
        public OfertaDto Oferta { get; init; }
    }
}
