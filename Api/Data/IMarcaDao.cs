using Api.Data.Dto;

namespace Api.Data
{
  public interface IMarcaDao
  {
    void Incluir(CreateMarcaDto dto);
    IEnumerable<ReadMarcaDto> Listar();
  }
}
