using Microsoft.EntityFrameworkCore;
using Teste.WebApi.Domain;
using Teste.WebApi.Domain.Enums;

namespace Teste.WebApi.DataContext
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Username)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Email)
                .HasColumnType("VARCHAR(60)")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Telefone)
                .HasColumnType("VARCHAR(14)")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Senha)
                .HasColumnType("VARCHAR(12)")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .HasIndex(x => x.Email)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(x => x.Telefone)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasMany(p => p.PessoasFisicas)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId);


            modelBuilder.Entity<PessoaFisica>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.Nome)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.Sobrenome)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.DataNascimento)
                .HasColumnType("DATE")
                .IsRequired();
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.Email)
                .HasColumnType("VARCHAR(60)")
                .IsRequired();
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();
            modelBuilder.Entity<PessoaFisica>()
                .Property(p => p.RG)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();

            modelBuilder.Entity<PessoaFisica>()
                .HasIndex(p => p.Email)
                .IsUnique();

            modelBuilder.Entity<PessoaFisica>()
                .HasIndex(p => p.CPF)
                .IsUnique();

            modelBuilder.Entity<PessoaFisica>()
                .HasIndex(p => p.RG)
                .IsUnique();

            modelBuilder.Entity<PessoaFisica>()
                .HasMany(p => p.Enderecos)
                .WithOne(e => e.PessoaFisica)
                .HasForeignKey(e => e.PessoaFisicaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PessoaFisica>()
                .HasMany(p => p.Contatos)
                .WithOne(c => c.PessoaFisica)
                .HasForeignKey(e => e.PessoaFisicaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>()
                .Property(e => e.Logradouro)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .HasColumnType("CHAR(4)")
                .IsRequired();
            modelBuilder.Entity<Endereco>()
                .Property(e => e.Cidade)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();
            modelBuilder.Entity<Endereco>()
                .Property(e => e.EstadoUF)
                .HasColumnType("CHAR(2)")
                .IsRequired();
            modelBuilder.Entity<Endereco>()
                .Property(e => e.Complemento)
                .HasColumnType("VARCHAR(100)");

            modelBuilder.Entity<Endereco>()
                .Property(e => e.CEP)
                .HasColumnType("VARCHAR(8)")
                .IsRequired();

            modelBuilder.Entity<Contato>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Contato>()
                .Property(p => p.Nome)
                .HasColumnType("VARCHAR(60)")
                .IsRequired();
            modelBuilder.Entity<Contato>()
                .Property(c => c.ContatoEmail)
                .HasColumnType("VARCHAR(60)");

            modelBuilder.Entity<Contato>()
                .Property(c => c.ContatoTelefone)
                .HasColumnType("VARCHAR(13)");

            modelBuilder.Entity<Contato>()
                .Property(c => c.TipoContato)
                .HasConversion(v => v.ToString(), v => (ETipoContato)Enum.Parse(typeof(ETipoContato), v));

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
