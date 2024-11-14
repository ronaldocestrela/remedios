using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeRemedio.Models
{
    public class Medicamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do medicamento é obrigatório.")]
        [StringLength(150)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(500)]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
        [Display(Name = "Quantidade em Estoque")]
        public int QuantidadeEmEstoque { get; set; }

        [Required(ErrorMessage = "Validade é obrigatória.")]
        public DateTime Validade { get; set; }

        // Chave estrangeira para a Categoria
        [Required]
        public int CategoriaId { get; set; }

        // Propriedade de navegação
        public Categoria? Categoria { get; set; }
    }
}