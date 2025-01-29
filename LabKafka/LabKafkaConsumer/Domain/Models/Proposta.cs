namespace LabKafkaConsumer.Domain.Models
{
    public class Proposta
    {
        public Guid? Id { get; set; }
        public DateTime? Validade { get; set; }
        public Cliente Cliente { get; set; }
        public Oferta Oferta { get; set; }
    }
}
