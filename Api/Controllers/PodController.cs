using Api.Data;
using Api.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PodController:ControllerBase
  {
    IPodDao _dao;

    public PodController(IPodDao dao)
    {
      _dao = dao;
    }
    [HttpPost]
    public IActionResult Incluir(CreatePodDto dto)
    {
      _dao.Incluir(dto);
      return NoContent();
    }
    [HttpGet]
    public IEnumerable<ReadPodDto> Listar()
    {
      return _dao.Listar();
    }
  }
}
