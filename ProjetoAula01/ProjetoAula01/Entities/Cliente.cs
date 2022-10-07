namespace Aula1.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
