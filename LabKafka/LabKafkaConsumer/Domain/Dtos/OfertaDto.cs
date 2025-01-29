using LabKafkaConsumer.Domain.Models;
using System.Text.Json.Serialization;

namespace LabKafkaConsumer.Domain.Dtos
{
    public record OfertaDto
    {
        [JsonPropertyName("codigo_produto")]
        public Produtos Produto { get; init; }

        [JsonPropertyName("valor_aprovado")]
        public double ValorAprovado { get; init; }

        [JsonPropertyName("parcelas")]
        public short QuantidadeParcelas { get; init; }

        [JsonPropertyName("data_primeiro_vencimento")]
        public DateTime VencimentoPrimeiraParcela { get; init; }
    }
}
