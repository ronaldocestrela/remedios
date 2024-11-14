using System.ComponentModel.DataAnnotations;

namespace ControleDeRemedio.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(250)]
        public string? Descricao { get; set; }

        public virtual ICollection<Medicamento>? Medicamentos { get; set; }
    }
}