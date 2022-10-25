using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDeNegocio
{
    public class Articulo
        //indicar herencia ejemplo: class Articulo : cosa
    {
        public Articulo (int id, String nombre, double precio, String desc, Categoria categoria)
        {
            this.ID = id;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = desc;
            this.categoria = categoria;

        }
        //por un tema de orden de c# primero los constructores, luego los atributos, de ult los metodos.

        public int ID { get; set; }
        public String nombre { get; set; }
        public double precio { get; set; }
        public String descripcion { get; set; }
        public Categoria categoria { get; set; }


        public String Mostrar()
        {
            String print;

            print = $"ID {ID} Nombre {nombre} precio {precio} descripcion {descripcion} categoria {categoria}";

            return print;
        }


    }
}
