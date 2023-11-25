using Api.Data.Dto;
using Api.Model;
using AutoMapper;

namespace Api.Profiles
{
  public class MarcaProfile:Profile
  {
    public MarcaProfile()
    {
      CreateMap<CreateMarcaDto, Marca>();
      CreateMap<Marca, ReadMarcaDto>();
    }
  }
}
