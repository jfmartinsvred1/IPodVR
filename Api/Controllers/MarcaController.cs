using Api.Data;
using Api.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
  [ApiController]
  [Route("[Controller]")]
  public class MarcaController:ControllerBase
  {
    IMarcaDao _dao;

    public MarcaController(IMarcaDao dao)
    {
      _dao = dao;
    }
    [HttpPost]
    public IActionResult Incluir(CreateMarcaDto dto)
    {
      _dao.Incluir(dto);
      return NoContent();

    }
    [HttpGet]
    public IEnumerable<ReadMarcaDto> Listar()
    {
      return _dao.Listar();
    }
  }
}
