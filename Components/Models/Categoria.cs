using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models;

public class Categoria
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 letras.")]
    public string Nome { get; set; } = "";

    [Range(0, 100000, ErrorMessage = "A quantidade deve estar entre 0 e 100000.")]
    public int Quantidade { get; set; }
}