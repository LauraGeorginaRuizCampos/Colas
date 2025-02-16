using System;
using System.Collections.Generic;

class ColaDoble<T>
{
    private LinkedList<T> cola;

    public ColaDoble()
    {
        cola = new LinkedList<T>(); // La lista enlazada es como una cuerda floja, solo que para elementos en una cola.
    }

    public void AgregarFrente(T item)
    {
        cola.AddFirst(item); // Agregando al frente, como cuando metes la ropa debajo de la cama en lugar de doblarla.
        Console.WriteLine($"Elemento {item} agregado al frente de la cola doble.");
    }

    public void AgregarFinal(T item)
    {
        cola.AddLast(item); // Agregando al final, como cuando sigues procrastinando.
        Console.WriteLine($"Elemento {item} agregado al final de la cola doble.");
    }

    public T RemoverFrente()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("No hay nada que remover, como mis ganas de hacer ejercicio.");
            return default(T);
        }
        T item = cola.First.Value;
        cola.RemoveFirst(); // Eliminando del frente, como cuando sacas el papel higiénico del rollo.
        Console.WriteLine($"Elemento {item} removido del frente.");
        return item;
    }

    public T RemoverFinal()
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

    public bool EstaVacia()
    {
        return cola.Count == 0; // Verificando si está vacía, como la nevera un domingo en la noche.
    }

    public int Tamano()
    {
        return cola.Count; // Contando los elementos, como contar los días para las vacaciones.
    }
}

class Program
{
    static void Main()
    {
        ColaDoble<int> colaDoble = new ColaDoble<int>();

        colaDoble.AgregarFrente(1);
        colaDoble.AgregarFinal(2);
        colaDoble.AgregarFinal(3);
        Console.WriteLine("Tamaño de la cola doble: " + colaDoble.Tamano());
        colaDoble.RemoverFrente();
        Console.WriteLine("Tamaño después de remover del frente: " + colaDoble.Tamano());
        colaDoble.RemoverFinal();
        Console.WriteLine("¿Está vacía? " + colaDoble.EstaVacia());
    }
}
