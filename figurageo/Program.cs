using System;
using figurageo.MODELOS;

namespace figurageo
{
    class Program
    {
        static void Main(string[] args)
        {
            var figura = new Figura();
            figura._atributo1 = 2;

            var triangulo = new Triangulo();
            triangulo._atributo1 = 1;

            Console.WriteLine($"El valor del atributo 1 es: {figura._atributo1}");
        }   
    }
}
