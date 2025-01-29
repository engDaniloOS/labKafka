using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public record PropostaOutDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; init; }

        [JsonPropertyName("validade")]
        public DateTime Validade { get; init; }

        [JsonPropertyName("cliente")]
        public ClienteDto Cliente { get; init; }

        [JsonPropertyName("oferta")]
        public OfertaDto Oferta { get; init; }

        [JsonIgnore]
        public bool HasError { get; init; } = false;

        [JsonIgnore]
        public string? ErrorMessage { get; init; }
    }
}
