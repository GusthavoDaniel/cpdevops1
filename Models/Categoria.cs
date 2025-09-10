using System.ComponentModel.DataAnnotations;

namespace ProductCatalogAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Descricao { get; set; }
        
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        
        // Relacionamento um-para-muitos
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}

