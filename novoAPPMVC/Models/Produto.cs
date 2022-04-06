using System.ComponentModel.DataAnnotations;

namespace novoAPPMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "o Campo Descrição é OBRIGATORIO")]
        public string? Descricao { get; set; }

        [Range(1,10, ErrorMessage ="Valor fora da faixa, 0 até 10")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
