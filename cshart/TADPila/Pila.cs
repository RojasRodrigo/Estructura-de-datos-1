using System;

namespace TADPila
{
    public class Pila
    {
        private int[] elementos;
        private int tope;
        private int capacidad;

        public Pila(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new int[capacidad];
            tope = -1;
        }

        public bool EstaVacia()
        {
            return tope == -1;
        }

        public bool EstaLlena()
        {
            return tope == capacidad - 1;
        }

        public void Apilar(int elemento)
        {
            if (EstaLlena())
            {
                Console.WriteLine("La pila está llena. No se puede apilar más elementos.");
                return;
            }

            tope++;
            elementos[tope] = elemento;
            Console.WriteLine($"Elemento {elemento} apilado correctamente.");
        }

        public int Desapilar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            int elemento = elementos[tope];
            tope--;
            return elemento;
        }

        public int VerTope()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            return elementos[tope];
        }

        public void Mostrar()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            Console.WriteLine("Elementos de la pila:");
            for (int i = tope; i >= 0; i--)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
}