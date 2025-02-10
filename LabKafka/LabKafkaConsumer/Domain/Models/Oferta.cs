namespace LabKafkaConsumer.Domain.Models
{
    public class Oferta
    {
        public long Id { get; set; }
        public Produtos Produto { get; set; }
        public double ValorAprovado { get; set; }
        public short QuantidadeParcelas { get; set; }
        public DateTime VencimentoPrimeiraParcela { get; set; }
    }
}
