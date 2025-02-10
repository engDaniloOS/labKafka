using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public record PropostaDto
    {
        [JsonPropertyName("cliente")]
        public ClienteDto Cliente { get; init; }

        [JsonPropertyName("oferta")]
        public OfertaDto Oferta { get; init; }
    }
}
