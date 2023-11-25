using Api.Model;
using System.ComponentModel.DataAnnotations;

namespace Api.Data.Dto
{
  public class CreatePodDto
  {
    [Required]
    public string Sabor { get; set; }
    [Required]
    public string IdMarca { get; set; }
    [Required]
    public string Preco { get; set; }
    [Required]
    public int Puffs { get; set; }
  }
}
