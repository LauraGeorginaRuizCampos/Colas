using System;
using System.Collections.Generic;

class ColaDoble<T>
{
    private LinkedList<T> cola;

    public ColaDoble()
    {
        cola = new LinkedList<T>(); // Iniciando la cola doble, porque una sola no era suficiente.
    }

    public void PushFrente(T item)
    {
        cola.AddFirst(item); // Agregando al frente, como cuando metes la ropa debajo de la cama en lugar de doblarla.
        Console.WriteLine($"Elemento {item} agregado al frente de la cola doble.");
    }

    public void PushFinal(T item)
    {
        cola.AddLast(item); // Agregando al final, como cuando sigues procrastinando.
        Console.WriteLine($"Elemento {item} agregado al final de la cola doble.");
    }

    public T PopFrente()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay nada que remover, como mis ganas de hacer ejercicio.");
            return default(T);
        }
        T item = cola.First.Value;
        cola.RemoveFirst(); // Quitando del frente, como sacar el primer pan de la bolsa.
        Console.WriteLine($"Elemento {item} removido del frente.");
        return item;
    }

    public T PopFinal()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("Nada que quitar, igual que cuando reviso mi billetera.");
            return default(T);
        }
        T item = cola.Last.Value;
        cola.RemoveLast(); // Quitando del final, como cuando se acaba la serie y no sabes qué hacer con tu vida.
        Console.WriteLine($"Elemento {item} removido del final.");
        return item;
    }

    public T PeekFrente()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("Nada que ver aquí, como mis mensajes a las 3 AM.");
            return default(T);
        }
        return cola.First.Value; // Observando el frente sin sacarlo, como mirar el pastel antes de comerlo.
    }

    public T PeekFinal()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("Nada que ver aquí, igual que mi cuenta bancaria.");
            return default(T);
        }
        return cola.Last.Value; // Observando el final sin tocarlo, como la última rebanada de pizza que nadie se atreve a tomar.
    }
}

class Program
{
    static void Main()
    {
        ColaDoble<int> cola = new ColaDoble<int>();

        cola.PushFrente(1);
        cola.PushFinal(2);
        cola.PushFinal(3);
        Console.WriteLine("Elemento al frente: " + cola.PeekFrente());
        Console.WriteLine("Elemento al final: " + cola.PeekFinal());
        cola.PopFrente();
        cola.PopFinal();
        Console.WriteLine("Elemento al frente después de sacar uno: " + cola.PeekFrente());
    }
}

