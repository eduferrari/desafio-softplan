using Microsoft.AspNetCore.Mvc;
using System;
using TaxaJurosAPI.Services;

namespace TaxaJurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Retorna a taxa de juros composto.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/taxaJuros")]
        public IActionResult BuscaTaxaJuros()
        {
            try
            {
                var taxaJurosService = new TaxaJurosService();
                return Ok(taxaJurosService.TaxaJurosComposto());
            }
            catch (Exception )
            {
                return BadRequest("Ops! Ocorreram erros ao consultar a taxa de juros, tente novamente!");
            }
        }
    }
}
