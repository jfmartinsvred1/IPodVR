using System.ComponentModel.DataAnnotations;

namespace Api.Data.Dto
{
  public class ReadPodDto
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
