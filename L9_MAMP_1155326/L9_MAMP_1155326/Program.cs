using System;
class Program
{
    static void Main()
    {
        // Entrada de usuario
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        // Salida de datos

        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        //Ejercicio 1
        Console.WriteLine("----------EJERCICIO 1-----------");
        caracter("Raton");
        caracter("Insomnio");

        //Ejercicio 2
        int a = 4;
        int b = 13;

        Console.WriteLine("----------EJERCICIO 2-----------");
        Console.WriteLine("Antes: ");
        Console.WriteLine("A= " + a);
        Console.WriteLine("B= " + b);

        intercambio(ref a, ref b);

        Console.WriteLine("Después: ");
        Console.WriteLine("A= " + a);
        Console.WriteLine("B= " + b);

        //Ejercicio 3
        double precio = 48.50;
        double descuento = 0.15;

        Console.WriteLine("----------EJERCICIO 3-----------");

        //Antes
        Console.WriteLine("Precio original: " + precio);

        aplicardes(descuento, ref precio);

        Console.WriteLine("Precio con descuento: " + precio);

        //Ejercicio 4
        int puntosSalud = 10;
        Console.WriteLine("----------EJERCICIO 4-----------");
        mostrarSalud(puntosSalud);
        recibirDaño(ref puntosSalud);
        mostrarSalud(puntosSalud);
        curar(ref puntosSalud);
        mostrarSalud(puntosSalud);
        calificarDesempeno(puntosSalud);
    }
    //Ejercicio 1 - procedimiento
    static void caracter(string a)
    {
        Console.WriteLine(a.Length);
    }

    //Ejercicio 2 - procedimiento
    static void intercambio(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    //Ejercicio 3 - procedimiento
    static void aplicardes(double descuento, ref double precio)
    {
        precio = precio - (precio * descuento);
    }
    //Ejercicio 4 - procedimiento
    //a) Recibir daño
    static void recibirDaño(ref int puntosSalud)
    {
        puntosSalud = puntosSalud - 5;
        if(puntosSalud<0)
        {
            puntosSalud = 0;
        }
    }
    //b) curar
    static void curar(ref int puntosSalud)
    {
        puntosSalud = puntosSalud + 3;
        if(puntosSalud>15)
        {
            puntosSalud = 15;
        }
    }
    //c) mostrad salud
    static void mostrarSalud(int puntosSalud)
    {
        if (puntosSalud >= 11)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if(puntosSalud>=6)
        { 
            Console.ForegroundColor=ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Salud actual: " + puntosSalud);
        Console.ResetColor();
    }
    // d) calificar desempeño
    static void calificarDesempeno(int puntosSalud)
    {
        if (puntosSalud == 15)
        {
            Console.WriteLine("Calificación: S");
        }
        else if (puntosSalud >= 11)
        {
            Console.WriteLine("Calificación: A");
        }
        else if (puntosSalud >= 6)
        {
            Console.WriteLine("Calificación: B");
        }
        else if (puntosSalud >= 1)
        {
            Console.WriteLine("Calificación: C");
        }
        else
        {
            Console.WriteLine("Calificación: Derrotado");
        }
    }
}
