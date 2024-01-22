namespace Teste.WebApi.Domain
{
    public class PessoaFisica
    {
        public PessoaFisica()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Contato> Contatos { get; set; } = new List<Contato>();
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}
