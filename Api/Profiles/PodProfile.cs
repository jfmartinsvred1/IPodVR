using Api.Data.Dto;
using Api.Model;
using AutoMapper;

namespace Api.Profiles
{
  public class PodProfile:Profile
  {
    public PodProfile()
    {
      CreateMap<CreatePodDto, Pod>();
      CreateMap<Pod, ReadPodDto>();
    }
  }
}
