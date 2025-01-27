using LabKafkaProducer.Domain.Models;
using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public class PropostaOutDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("validade")]
        public DateTime Validade { get; set; }

        [JsonPropertyName("cliente")]
        public Cliente Cliente { get; set; }

        [JsonPropertyName("oferta")]
        public Oferta Oferta { get; set; }

        [JsonIgnore]
        public bool HasError { get; set; } = false;

        [JsonIgnore]
        public string? ErrorMessage { get; set; }
    }
}
