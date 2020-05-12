using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.WebAPi.Data;
using Api.WebAPi.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebAPi.Controllers
{
    // api/paises
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly ApiContext context;
        public PaisesController(ApiContext context)
        {

            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Pais>> Get()
        {
            return context.Paises.ToList();
        }
    }
}