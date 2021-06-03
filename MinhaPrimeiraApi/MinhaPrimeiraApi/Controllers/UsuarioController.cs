using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Controllers

{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]

        public IActionResult ObterUsuario()
        {
            return Ok(" ola mundo, meu primeiro API Csharp");
        }
    }
}
