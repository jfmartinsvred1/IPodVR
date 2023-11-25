using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
  public class Marca
  {
    [Key]
    [Required]
    [MaxLength(10)]
    public string IdMarca { get; set; }
    public  ICollection<Pod> Pods { get; set; }
  }
}
