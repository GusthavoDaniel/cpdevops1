using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Models;

namespace ProductCatalogAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração do relacionamento
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Dados iniciais
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nome = "Eletrônicos", Descricao = "Produtos eletrônicos em geral", DataCriacao = DateTime.Now },
                new Categoria { Id = 2, Nome = "Roupas", Descricao = "Vestuário e acessórios", DataCriacao = DateTime.Now }
            );

            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "Smartphone", Descricao = "Smartphone Android", Preco = 899.99m, Estoque = 50, CategoriaId = 1, DataCriacao = DateTime.Now },
                new Produto { Id = 2, Nome = "Notebook", Descricao = "Notebook para trabalho", Preco = 2499.99m, Estoque = 25, CategoriaId = 1, DataCriacao = DateTime.Now },
                new Produto { Id = 3, Nome = "Camiseta", Descricao = "Camiseta 100% algodão", Preco = 49.99m, Estoque = 100, CategoriaId = 2, DataCriacao = DateTime.Now }
            );
        }
    }
}

