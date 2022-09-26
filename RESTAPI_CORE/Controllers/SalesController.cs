using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RESTAPI_CORE.Datos;
using RESTAPI_CORE.Entities;
using RESTAPI_CORE.Logica;
using System.Data;
using System.Data.SqlClient;

namespace RESTAPI_CORE.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SalesController : ControllerBase
    {

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista([FromBody] enSales.parameters json)
        {
            List<enSales.responseSummary> lista = new List<enSales.responseSummary>();            
            SalesLogica salesLogica = new SalesLogica();
            var respuesta = await salesLogica.ListadoVentas(json);


            if (respuesta.Count != 0){
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = respuesta });
            }
            return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", response = respuesta });

        }
    }
}
