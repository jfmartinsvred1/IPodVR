using Api.Data.Dto;
using Api.Model;
using AutoMapper;

namespace Api.Data.EfCore
{
  public class PodDaoComEfCore : IPodDao
  {
    IMapper _mapper;
    PodContext _podContext;

    public PodDaoComEfCore(IMapper mapper, PodContext podContext)
    {
      _mapper = mapper;
      _podContext = podContext;
    }

    public void Incluir(CreatePodDto dto)
    {
      Pod pod = _mapper.Map<Pod>(dto);
      _podContext.Pods.Add(pod);
      _podContext.SaveChanges();
    }

    public IEnumerable<ReadPodDto> Listar()
    {
      return _mapper.Map<List<ReadPodDto>>(_podContext.Pods.ToList());
    }
  }
}
