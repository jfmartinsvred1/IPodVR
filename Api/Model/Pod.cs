using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
  public class Pod
  {
    [Key]
    [Required]
    public int IdPod { get; set; }
    [Required]
    public string Sabor { get; set; }
    [Required]
    public string IdMarca { get; set; }
    [Required]
    public virtual Marca Marca { get; set; }
    [Required]
    public string Preco { get; set; }
    [Required]
    public int Puffs { get; set; }
  }
}
