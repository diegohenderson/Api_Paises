using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.WebAPi.Data.Entities
{
    public class Provincia
    {
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string NombreProv { get; set; }
        public Pais Pais { get; set; }
    }
}
