using System.ComponentModel.DataAnnotations;

namespace HeloFlix.Models;

public class Genre
{
    [Key] //Define a propriedade como Chave Primária. 
    public byte Id {get; set; }

    [Required] //Requerido - Not Null; Validação.
    [StringLength(30)] // Tamanho máximo da propriedade.
    public string Name { get; set; }
}
