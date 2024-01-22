using Teste.WebApi.Domain;

namespace Teste.WebApi.Data
{
    public interface IUsuarioRepositorio
    {
        Task CadastrarUsuario(Usuario usuario);
        Task CadastrarPessoaFisica(PessoaFisica pessoaFisica);
    }
}
