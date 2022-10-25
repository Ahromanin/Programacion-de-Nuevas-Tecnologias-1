using System;
using System.Collections.Generic;
using ClasesDeNegocio;

namespace EjemploList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a Com.prando!");


            Usuario a = new Usuario(1, "Juan Sabina", 1100002222, "juan@yahoo.com", true);

            Categoria ropa = new Categoria(11, "Ropa", "Prendas de vestir para humanos");

            Articulo camisa1 = new Articulo(111, "Camisa Gris", 10.50, "Camisa formal", ropa);
            Articulo camisa2 = new Articulo(112, "Camisa Amarilla", 10.50, "Camisa formal", ropa);
            Articulo camisa3 = new Articulo(113, "Camisa Roja", 10.50, "Camisa formal", ropa);
            Articulo camisa4 = new Articulo(114, "Camisa Verde", 10.50, "Camisa formal", ropa);
            Articulo camisa5 = new Articulo(115, "Camisa Negra", 10.50, "Camisa formal", ropa);

            List<Articulo> prendasRopa = new List<Articulo>();
            prendasRopa.Add(camisa5);
            prendasRopa.Add(camisa4);
            prendasRopa.Add(camisa3);
            prendasRopa.Add(camisa2);
            prendasRopa.Add(camisa1);


            foreach (Articulo art in prendasRopa)
            {
                Console.WriteLine(art.Mostrar());
            }







            Console.WriteLine("Hello World!");
        }
    }
}
