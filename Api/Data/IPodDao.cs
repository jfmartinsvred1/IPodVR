using Api.Data.Dto;

namespace Api.Data
{
  public interface IPodDao
  {
    void Incluir(CreatePodDto dto);
    IEnumerable<ReadPodDto> Listar();
  }
}
