using System;
using System.Collections.Generic;

class ColaSimple<T>
{
    private Queue<T> cola;

    public ColaSimple()
    {
        cola = new Queue<T>(); // Iniciando la cola, lista para recibir elementos como fila en la tienda un viernes negro.
    }

    public void Push(T item)
    {
        cola.Enqueue(item); // Agregando elemento al final, como cuando sigues metiendo ropa sucia en la canasta sin lavar.
        Console.WriteLine($"Elemento {item} agregado a la cola.");
    }

    public T Pop()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay nada que sacar, esto está más vacío que mi cuenta bancaria.");
            return default(T);
        }
        T item = cola.Dequeue(); // Sacando el elemento al frente, como cuando finalmente lavas esa ropa acumulada.
        Console.WriteLine($"Elemento {item} sacado de la cola.");
        return item;
    }

    public T Peek()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("Nada que ver aquí, igual que en mi historial de mensajes un sábado por la noche.");
            return default(T);
        }
        return cola.Peek(); // Observando el frente de la cola sin sacarlo, como revisar el refrigerador sin sacar nada.
    }
}

class Program
{
    static void Main()
    {
        ColaSimple<int> cola = new ColaSimple<int>();

        cola.Push(1);
        cola.Push(2);
        cola.Push(3);
        Console.WriteLine("Elemento al frente: " + cola.Peek());
        cola.Pop();
        Console.WriteLine("Elemento al frente después de sacar uno: " + cola.Peek());
    }
}

