using Teste.WebApi.Domain.Enums;

namespace Teste.WebApi.Domain
{
    public class Contato
    {
        public Contato()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string ContatoEmail { get; set; } = string.Empty;
        public string ContatoTelefone { get; set; } = string.Empty;
        public ETipoContato TipoContato { get; set; }
        public Guid PessoaFisicaId { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
    }
}
