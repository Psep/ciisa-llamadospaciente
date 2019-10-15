using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LlamadoPacientes.Models
{
    public class Box
    {
        public int numero { get; set; }
        public string estado { get; set; }
        public Profesional profesional { get; set; }
    }
}