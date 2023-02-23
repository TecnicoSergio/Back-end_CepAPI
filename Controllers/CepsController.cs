using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CepApi.Models;

namespace CepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepsController : ControllerBase
    {
        private Descricao d = new Descricao();
        public IActionResult Get()
        {
            return Ok(d);
        }
        
    }
}