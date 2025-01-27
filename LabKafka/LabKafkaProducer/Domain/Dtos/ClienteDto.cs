using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public class ClienteDto
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }

        [JsonPropertyName("data_nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
