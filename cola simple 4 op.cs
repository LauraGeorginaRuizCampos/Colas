using System;

class ColaSimple<T>
{
    private T[] elementos;
    private int frente;
    private int final;
    private int capacidad;
    private int contador;

    public ColaSimple(int capacidad)
    {
        this.capacidad = capacidad;
        elementos = new T[capacidad]; // Lista de espera para los elementos, pero sin boletos numerados.
        frente = 0;
        final = -1;
        contador = 0;
    }

    public void Enqueue(T item)
    {
        if (contador == capacidad)
        {
            Console.WriteLine("La cola está llena, como un autobús en hora pico.");
            return;
        }
        final = (final + 1) % capacidad;
        elementos[final] = item;
        contador++;
        Console.WriteLine($"Elemento {item} agregado a la cola.");
    }

    public T Dequeue()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nada que sacar, como cuando revisas la nevera esperando que aparezca comida mágica.");
            return default(T);
        }
        T item = elementos[frente];
        frente = (frente + 1) % capacidad;
        contador--;
        Console.WriteLine($"Elemento {item} removido de la cola.");
        return item;
    }

    public T Front()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nada al frente, igual que mis planes para el fin de semana.");
            return default(T);
        }
        return elementos[frente]; // Mirando el primer elemento sin moverlo, como observar el menú sin pedir nada.
    }

    public T Rear()
    {
        if (contador == 0)
        {
            Console.WriteLine("Nada atrás, como cuando intentas recordar dónde dejaste las llaves.");
            return default(T);
        }
        return elementos[final]; // Mirando el último elemento sin tocarlo, como la última galleta en el frasco.
    }
}

class Program
{
    static void Main()
    {
        ColaSimple<int> cola = new ColaSimple<int>(5);

        cola.Enqueue(1);
        cola.Enqueue(2);
        cola.Enqueue(3);
        Console.WriteLine("Elemento al frente: " + cola.Front());
        Console.WriteLine("Elemento al final: " + cola.Rear());
        cola.Dequeue();
        Console.WriteLine("Elemento al frente después de sacar uno: " + cola.Front());
    }
}

