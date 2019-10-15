using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LlamadoPacientes.Models
{
    public class Profesional
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
        public string especialidad { get; set; }
    }
}