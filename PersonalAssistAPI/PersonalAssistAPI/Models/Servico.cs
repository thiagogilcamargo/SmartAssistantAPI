namespace PersonalAssistAPI.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCriacao { get; set; }

        // Você pode adicionar outros atributos conforme necessário
    }
}
