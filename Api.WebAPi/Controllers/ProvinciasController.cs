using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.WebAPi.Data;
using Api.WebAPi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.WebAPi.Controllers
{
    // api/provincias
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly ApiContext context;

        public ProvinciasController(ApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Provincia>> Get()
        {
            return context.Provincias.Include(p => p.Pais).ToList();
        }

        
        [HttpGet("{id}", Name = "ObtenerProvinciaPorId")]
        public ActionResult<Provincia> Get(int id)
        {
            var provincia = context.Provincias.FirstOrDefault(p => p.Id == id);
            if (provincia == null)
            {
                return NotFound();

            }
            return provincia;
        }

        [HttpPost]
        public ActionResult<Provincia> Post([FromBody]Provincia  provincia)
        //public async Task<ActionResult<Provincia>> Post([FromBody]Provincia provincia)
        {
            context.Provincias.Add(provincia);
            //await context.Provincia.AddAsync(Provincia);
            context.SaveChanges();
            //await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerProvinciaPorId", new { id = provincia.Id }, provincia);
            //return pais;

        }
    }
}