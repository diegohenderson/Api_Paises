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
        //nuevo con lamda
        [HttpGet("{id}", Name = "ObtenerPaisPorId")]
        public ActionResult<Pais> Get(int id)
        {
            var pais = context.Paises.FirstOrDefault(p => p.Id == id);
            if (pais == null)
            {
                return NotFound();

            }
            return pais;
        }


        [HttpPost]
        //public ActionResult<Pais> Post([FromBody]Pais pais)
        public async Task<ActionResult<Pais>> Post([FromBody]Pais pais)
        {
            //context.Paises.Add(pais);
            await context.Paises.AddAsync(pais);
            //context.SaveChanges();
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerPaisPorId", new { id = pais.Id }, pais);
            //return pais;

        }
        //put
        [HttpPut("{id}")]
        public ActionResult<Pais> Put(int id, [FromBody] Pais pais)
        {
            if (id!= pais.Id)
            {
                return BadRequest();
            }
            context.Entry(pais).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult<Pais>Delete(int id)
        {
            var pais = context.Paises.FirstOrDefault(p => p.Id == id);
            if (pais==null)     
            {
                return NotFound();
            }
            context.Paises.Remove(pais);
            context.SaveChanges();
            return Ok();
        }
    }
}