using Fornecedores.Api.Data;
using Fornecedores.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedores.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepository _repositorio;
        private readonly ILogger<FornecedorController> _logger;

        public FornecedorController(IFornecedorRepository repositorio, ILogger<FornecedorController> logger)
        {
            _repositorio = repositorio;
            _logger = logger;
        }
       
        [HttpPost("Criar")]
        public IActionResult Criar([FromBody] Fornecedor fornecedor)
        {
            _repositorio.Inserir(fornecedor);
            return Created(nameof(Criar), fornecedor);
        }

        [HttpGet]
        public IActionResult Obter()
        {
            var lista = _repositorio.Obter();
            return Ok(lista);
        }

        [HttpGet("{Guid }")]
        public IActionResult Obter(Guid id)
        {
            var fornecedor = _repositorio.Obter(id);
            if (fornecedor == null) return NotFound();
            return Ok(fornecedor);
        }


        [HttpPut]
        public IActionResult Atualizar([FromBody] Fornecedor fornecedor)
        {
            var prod = _repositorio.Obter(fornecedor.Id);
            if (prod == null) return NotFound();

            _repositorio.Editar(fornecedor);
            return NoContent();
        }

        [HttpDelete("{Guid }")]
        public IActionResult Apagar(Guid id)
        {
            var prod = _repositorio.Obter(id);
            if (prod == null) return NotFound();
            _repositorio.Excluir(prod);
            return Ok();
        }

        [HttpGet("helth")]
        public IActionResult Status(string codigo) => Ok($"{DateTime.Now} Api running");

    }
}
