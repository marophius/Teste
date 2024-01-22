namespace Teste.WebApi.Domain
{
    public class Endereco
    {
        public Endereco() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string EstadoUF { get; set; }
        public Guid PessoaFisicaId { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
    }
}
