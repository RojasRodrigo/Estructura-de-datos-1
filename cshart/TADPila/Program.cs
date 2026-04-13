using System;

namespace TADPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila(5);

            pila.Apilar(10);
            pila.Apilar(20);
            pila.Apilar(30);

            pila.Mostrar();

            Console.WriteLine($"Elemento en el tope: {pila.VerTope()}");

            Console.WriteLine($"Elemento desapilado: {pila.Desapilar()}");

            pila.Mostrar();
        }
    }
}