using System;
using WebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogoController : ControllerBase
    {
        public readonly IRepository _repo;
        public CatalogoController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return NewMethod();
        }

        private ActionResult NewMethod()
        {
            try
            {
                var catalogos = _repo.GetAllCatalogos();

                if (catalogos == null) return BadRequest("Não existe livros cadastrados!");

                return Ok(catalogos);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("frete/{id}")]
        public ActionResult GetId(int id)
        {
            try
            {
                var catalogos = _repo.GetCatalogoID(id);

                if (catalogos == null) return BadRequest("Não existe livros cadastrados!");

                return Ok(catalogos);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("busca={buscar}&sort={sort}")]
        public ActionResult GetBuscar(string buscar, string sort)
        {
            try
            {
                var catalogos = _repo.GetAllCatalgoByBusca(buscar, sort);

                if (catalogos == null) return BadRequest("O Livro não foi encontrado!");

                return Ok(catalogos);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}