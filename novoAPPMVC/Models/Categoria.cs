using System.ComponentModel.DataAnnotations;

namespace novoAPPMVC.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "o Campo Descrição é OBRIGATORIO")]
        public string? Descricao { get; set; }    

    
    }
}
