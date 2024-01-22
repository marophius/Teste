namespace Teste.WebApi.Domain
{
    public class Usuario
    {
        public Usuario()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public List<PessoaFisica> PessoasFisicas { get; set; } = new List<PessoaFisica>();
    }
}
