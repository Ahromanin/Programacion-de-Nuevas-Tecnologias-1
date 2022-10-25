using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDeNegocio
{
    public class Usuario
    {
        public Usuario(int id, String nombApellido, int telefono, String mail, Boolean esMayorDeEdad)
        {
            this.ID = id;
            this.nombApellido = nombApellido;
            this.telefono = telefono;
            this.mail = mail;
            this.esMayorDeEdad = esMayorDeEdad;

        }

        public int ID { get; set; }
        public String nombApellido { get; set; }
        public int telefono { get; set; }
        public String mail { get; set; }
        public Boolean esMayorDeEdad { get; set; }
    }
}
