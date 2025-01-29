using System.Text.Json.Serialization;

namespace LabKafkaProducer.Domain.Dtos
{
    public record ClienteDto
    {
        [JsonPropertyName("nome")]
        public string Nome { get; init; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; init; }

        [JsonPropertyName("data_nascimento")]
        public DateTime DataNascimento { get; init; }
    }
}
