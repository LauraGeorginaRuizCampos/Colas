using System;

class ColaCircular<T>
{
    private T[] elementos;
    private int frente;
    private int final;
    private int capacidad;
    private int contador;

    public ColaCircular(int capacidad)
    {
        this.capacidad = capacidad;
        elementos = new T[capacidad]; // Como una montaña rusa para los datos, pero sin mareos.
        frente = 0;
        final = -1;
        contador = 0;
    }

    public void Push(T item)
    {
        if (contador == capacidad)
        {
            Console.WriteLine("La cola está llena, como el tráfico en hora pico.");
            return;
        }
        final = (final + 1) % capacidad;
        elementos[final] = item;
        contador++;
        Console.WriteLine($"Elemento {item} agregado a la cola circular.");
    }

    public T Pop()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nada que sacar, esto está más vacío que mi nevera un fin de mes.");
            return default(T);
        }
        T item = elementos[frente];
        frente = (frente + 1) % capacidad;
        contador--;
        Console.WriteLine($"Elemento {item} removido de la cola circular.");
        return item;
    }

    public T Peek()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nada que ver aquí, como mis mensajes de texto un domingo.");
            return default(T);
        }
        return elementos[frente]; // Espiando el primer elemento sin sacarlo, como cuando miras la comida en el microondas.
    }
}

class Program
{
    static void Main()
    {
        ColaCircular<int> cola = new ColaCircular<int>(5);

        cola.Push(1);
        cola.Push(2);
        cola.Push(3);
        Console.WriteLine("Elemento al frente: " + cola.Peek());
        cola.Pop();
        Console.WriteLine("Elemento al frente después de sacar uno: " + cola.Peek());
    }
}
