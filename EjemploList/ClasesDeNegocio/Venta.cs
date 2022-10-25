using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDeNegocio
{
    public class Venta
    {
        public Venta (int id, Usuario usuario, Articulo articulo)
        {
            this.ID = id;
            this.usuario = usuario;
            this.articulo = articulo;

        }

        public int ID { get; set; }
        public Usuario usuario { get; set; }
        public Articulo articulo { get; set; }
    }
}
