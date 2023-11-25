using Api.Data.Dto;
using Api.Model;
using AutoMapper;

namespace Api.Data.EfCore
{
  public class MarcaDaoComEfCore : IMarcaDao
  {
    IMapper _mapper;
    PodContext _podContext;

    public MarcaDaoComEfCore(IMapper mapper, PodContext podContext)
    {
      _mapper = mapper;
      _podContext = podContext;
    }

    public void Incluir(CreateMarcaDto dto)
    {
      Marca marca = _mapper.Map<Marca>(dto);
      _podContext.Marcas.Add(marca);
      _podContext.SaveChanges();
    }

    public IEnumerable<ReadMarcaDto> Listar()
    {
      return _mapper.Map<List<ReadMarcaDto>>(_podContext.Marcas.ToList());
    }
  }
}
