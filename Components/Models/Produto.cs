using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        // As regras de validação ficam no próprio modelo (DataAnnotations).
        // O EditForm + DataAnnotationsValidator leem esses atributos e conferem os dados.

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; } = "";

        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
