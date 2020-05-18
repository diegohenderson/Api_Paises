using Api.WebAPi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.WebAPi.Data
{
    
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia>Provincias { get; set; }
    }
}
