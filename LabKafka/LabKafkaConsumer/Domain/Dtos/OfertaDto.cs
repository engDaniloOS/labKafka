using LabKafkaConsumer.Domain.Models;
using System.Text.Json.Serialization;

namespace LabKafkaConsumer.Domain.Dtos
{
    public class OfertaDto
    {
        [JsonPropertyName("codigo_produto")]
        public Produtos Produto { get; set; }

        [JsonPropertyName("valor_aprovado")]
        public double ValorAprovado { get; set; }

        [JsonPropertyName("parcelas")]
        public short QuantidadeParcelas { get; set; }

        [JsonPropertyName("data_primeiro_vencimento")]
        public DateTime VencimentoPrimeiraParcela { get; set; }
    }
}
