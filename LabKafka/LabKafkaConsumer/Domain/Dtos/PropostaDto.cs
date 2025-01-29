using System.Text.Json.Serialization;

namespace LabKafkaConsumer.Domain.Dtos
{
    public class PropostaDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("validade")]
        public DateTime Validade { get; set; }

        [JsonPropertyName("cliente")]
        public ClienteDto Cliente { get; set; }

        [JsonPropertyName("oferta")]
        public OfertaDto Oferta { get; set; }
    }
}
