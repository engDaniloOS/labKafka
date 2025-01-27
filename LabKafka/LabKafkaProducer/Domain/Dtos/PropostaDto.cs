using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public class PropostaDto
    {
        [JsonPropertyName("cliente")]
        public ClienteDto Cliente { get; set; }

        [JsonPropertyName("oferta")]
        public OfertaDto Oferta { get; set; }
    }
}
