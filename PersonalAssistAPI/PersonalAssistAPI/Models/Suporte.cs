namespace PersonalAssistAPI.Models
{
    public class Suporte
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataContato { get; set; }

        // Voc� pode adicionar outros atributos conforme necess�rio
    }
}
