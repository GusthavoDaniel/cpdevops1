using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductCatalogAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        // Chave estrangeira
        [Required]
        public int CategoriaId { get; set; }

        // Propriedade de navegação (opcional no binding/JSON)
        [JsonIgnore] // não exigir no body e não serializar por padrão
        public virtual Categoria? Categoria { get; set; }
    }
}
