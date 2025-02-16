using System;
using System.Collections.Generic;

class ColaDePrioridad<T> where T : IComparable<T>
{
    private List<T> elementos;

    public ColaDePrioridad()
    {
        elementos = new List<T>(); // Una lista que trata a los elementos como si fueran VIP en una fiesta.
    }

    public void Push(T item)
    {
        elementos.Add(item);
        elementos.Sort(); // Ordenando para que los más importantes vayan primero, como en un aeropuerto.
        Console.WriteLine($"Elemento {item} agregado a la cola de prioridad.");
    }

    public T Pop()
    {
        if (elementos.Count == 0)
        {
            Console.WriteLine("Nada que sacar, como cuando revisas tu billetera y solo hay aire.");
            return default(T);
        }
        T item = elementos[0];
        elementos.RemoveAt(0); // Quitando al más prioritario, como el primero en la fila de un concierto.
        Console.WriteLine($"Elemento {item} removido de la cola de prioridad.");
        return item;
    }

    public T Peek()
    {
        if (elementos.Count == 0)
        {
            Console.WriteLine("Nada que ver aquí, como mi lista de pendientes después de procrastinar.");
            return default(T);
        }
        return elementos[0]; // Mirando al rey de la colina sin moverlo.
    }
}

class Program
{
    static void Main()
    {
        ColaDePrioridad<int> cola = new ColaDePrioridad<int>();

        cola.Push(3);
        cola.Push(1);
        cola.Push(2);
        Console.WriteLine("Elemento con mayor prioridad: " + cola.Peek());
        cola.Pop();
        Console.WriteLine("Elemento con mayor prioridad después de sacar uno: " + cola.Peek());
    }
}

