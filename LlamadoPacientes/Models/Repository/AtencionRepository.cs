using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LlamadoPacientes.Models.Repository
{
    public class AtencionRepository
    {

        public List<Atencion> listAtencionesCarrusel()
        {
            List<Atencion> listAtencion = new List<Atencion>();

            Atencion atencion7 = new Atencion();
            atencion7.box = new Box();
            atencion7.box.numero = 7;
            atencion7.box.profesional = new Profesional();
            atencion7.box.profesional.nombre = "Dr. Juanito Oyarce";
            atencion7.paciente = new Paciente();
            atencion7.paciente.codigo = 1345;
            atencion7.paciente.nombre = "Lolito Los Palotes";
            listAtencion.Add(atencion7);

            Atencion atencion8 = new Atencion();
            atencion8.box = new Box();
            atencion8.box.numero = 1;
            atencion8.box.profesional = new Profesional();
            atencion8.box.profesional.nombre = "Dr. Juan Oyarzún";
            atencion8.paciente = new Paciente();
            atencion8.paciente.codigo = 1;
            atencion8.paciente.nombre = "Pepito Los Palotes";
            listAtencion.Add(atencion8);

            Atencion atencion9 = new Atencion();
            atencion9.box = new Box();
            atencion9.box.numero = 2;
            atencion9.box.profesional = new Profesional();
            atencion9.box.profesional.nombre = "Dra. Juana López";
            atencion9.paciente = new Paciente();
            atencion9.paciente.codigo = 2332;
            atencion9.paciente.nombre = "Armando Casas";
            listAtencion.Add(atencion9);

            Atencion atencion10 = new Atencion();
            atencion10.box = new Box();
            atencion10.box.numero = 3;
            atencion10.box.profesional = new Profesional();
            atencion10.box.profesional.nombre = "Dra. Angela Algo";
            atencion10.paciente = new Paciente();
            atencion10.paciente.codigo = 11111;
            atencion10.paciente.nombre = "Daniel López";
            listAtencion.Add(atencion10);

            return listAtencion;
        }

        public List<Atencion> listUltimasAtenciones()
        {
            List<Atencion>  listAtencion = new List<Atencion>();

            Atencion atencion1 = new Atencion();
            atencion1.box = new Box();
            atencion1.box.numero = 1;
            atencion1.box.profesional = new Profesional();
            atencion1.box.profesional.nombre = "Dr. Juan Oyarzún";
            atencion1.paciente = new Paciente();
            atencion1.paciente.codigo = 1;
            atencion1.paciente.nombre = "Pepito Los Palotes";
            listAtencion.Add(atencion1);

            Atencion atencion2 = new Atencion();
            atencion2.box = new Box();
            atencion2.box.numero = 2;
            atencion2.box.profesional = new Profesional();
            atencion2.box.profesional.nombre = "Dra. Juana López";
            atencion2.paciente = new Paciente();
            atencion2.paciente.codigo = 2332;
            atencion2.paciente.nombre = "Armando Casas";
            listAtencion.Add(atencion2);

            Atencion atencion3 = new Atencion();
            atencion3.box = new Box();
            atencion3.box.numero = 3;
            atencion3.box.profesional = new Profesional();
            atencion3.box.profesional.nombre = "Dra. Angela Algo";
            atencion3.paciente = new Paciente();
            atencion3.paciente.codigo = 11111;
            atencion3.paciente.nombre = "Daniel López";
            listAtencion.Add(atencion3);

            return listAtencion;
        }

    }
}