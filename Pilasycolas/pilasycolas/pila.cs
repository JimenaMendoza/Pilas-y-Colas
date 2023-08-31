using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PilaCola
{
    class Prueba
    {
        static void Main(string[] args)
        {
            Stack<int> pila1 = new Stack<string>();
            Console.WriteLine("Insertamos nombres en la pila:'jimena', 'angel' ,'pablo 'ana', 'juan' y 'pedro");
            pila1.Push("jimena");
            pila1.Push("angel");
            pila1.Push("pablo");
            pila1.Push("ana");
            pila1.Push("juan");
            pila1.Push("pedro");
            Console.WriteLine("Cantidad de elementos en la pila:" + pila1.Count);
            Console.WriteLine("Extraemos un elemento de la pila:" + pila1.Pop());
            Console.WriteLine("Cantidad de elementos en la pila:" + pila1.Count);

            Queue<string> cola1 = new Queue<string>();
            Console.WriteLine("Insertamos los 12 meses en la cola:'enero', 'febrero', 'marzo', 'abril', 'mayo', 'junio', 'julio' , 'agosto' , 'septiembre', 'octubre', 'noviembre' y 'diciembre'");
            cola1.Enqueue("enero");
            cola1.Enqueue("febrero");
            cola1.Enqueue("marzo");
            cola1.Enqueue("abril");
            cola1.Enqueue("mayo");
            cola1.Enqueue("junio");
            cola1.Enqueue("julio");
            cola1.Enqueue("agosto");
            cola1.Enqueue("septiembre");
            cola1.Enqueue("octubre");
            cola1.Enqueue("noviembre");
            cola1.Enqueue("diciembre");
            Console.WriteLine("Cantidad de elementos en la cola:" + cola1.Count);
            Console.WriteLine("Extraemos un elemento de la cola:" + cola1.Dequeue());
            Console.WriteLine("Cantidad de elementos en la cola:" + cola1.Count);
            Console.ReadKey();
        }
    }
}