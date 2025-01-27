namespace LabKafkaProducer.Domain.Models
{
    public class Oferta
    {
        public Produtos Produto { get; set; }
        public double ValorAprovado { get; set; }
        public short QuantidadeParcelas { get; set; }
        public DateTime VencimentoPrimeiraParcela { get; set; }
    }
}
