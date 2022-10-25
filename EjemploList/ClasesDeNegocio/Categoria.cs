using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDeNegocio
{
    public class Categoria
    {
        public Categoria(int id, String nombre, String descripcion)
        {
            this.ID = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public int ID { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }


    }
}
