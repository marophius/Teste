using Teste.WebApi.DataContext;
using Teste.WebApi.Domain;

namespace Teste.WebApi.Data
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task CadastrarPessoaFisica(PessoaFisica pessoaFisica)
        {
            await _context.PessoasFisicas.AddAsync(pessoaFisica);
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
        }
    }
}
