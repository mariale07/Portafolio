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

        //EJERCICIO 1
        Console.WriteLine("------------ Ejercicio 1 ------------");
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = sumardigitos(numero);

        Console.WriteLine("La suma de los dígitos es: " + resultado);

        //EJERCICIO 2
        Console.WriteLine("------------ Ejercicio 2 ------------");
        Console.WriteLine("Ingrese su primer nombre: ");
        String nombre1 = Console.ReadLine();
        Console.WriteLine("Ingrse su segundo nombre: ");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido paterno: ");
        string apellido1 = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido materno: ");
        string apellido2 = Console.ReadLine();

        string correo = generar_correo(nombre1, nombre2, apellido1, apellido2);

        Console.WriteLine("Correo institucional: " + correo);

        //EJERCICIO 3
        Console.WriteLine("------------ Ejercicio 3 ------------");
        Console.WriteLine("Ingrese una temperatura en Celsius: ");
        string celsius = Console.ReadLine();

        double fahrenheit = 0;
        string respuesta = temperatura(celsius, ref fahrenheit);

        Console.WriteLine(respuesta);

        //EJERCICIO 4
        Console.WriteLine("------------ Ejercicio 4 ------------");
        //puntos 4.1
        int puntos = 0;

        puntos = agregarpuntos(ref puntos);
        puntos = quitarpuntos(ref puntos);
            string nivel = obtenernivel(puntos);
        string estado = evaluarestado(puntos);

        Console.WriteLine("Puntos: " + puntos);
        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Estado: " + estado);
    }

    //Función - ejercicio 1
    static int sumardigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma = suma + (numero % 10);
            numero = numero / 10;
        }
        return suma;
    }

    //Función - ejercicio 2
    static string generar_correo(string nombre1, string nombre2, string apellido1, string apellido2)
    {
    string correo = "";
    correo = nombre1.Substring(0,1) + nombre2.Substring(0,1) + apellido1 + apellido2.Substring(0,1) + "@correo.url.edu.gt";

        return correo.ToLower();
    }

    //Integración - ejercicio 3
    static string temperatura(string celsius, ref double fahrenheit)
    {
        string num = celsius.Replace("C = ", "");
        double tempC = double.Parse(num);
        fahrenheit = (tempC * 9 / 5) + 32;

        return celsius + "°C -->" + "°F = " + fahrenheit;
    }

    //Agregar puntos 4.1
    static int agregarpuntos(ref int puntos)
    {
        puntos = puntos + 10;

        if (puntos > 100)
        {
            puntos = 100;
        }
        return puntos;
    }

    //Quitar puntos 4.2
    static int quitarpuntos(ref int puntos)
    {
        puntos = puntos - 7;

        if (puntos < 0)
        {
            puntos = 0;
        }
        return puntos;
    }

    //Nivel 4.3
    static string obtenernivel(int puntos)
    {
        if (puntos >= 80 && puntos <= 100)
        {
            return "Avanzado";
        }
        else if (puntos >=50 && puntos <= 79)
        {
            return "Intermedio";
        }
        else
        {
            return "Básico";
        }
    }

    //Estado 4.4
    static string evaluarestado(int puntos)
    {
        if (puntos ==100)
        {
            return "Excelente";
        }
        else if (puntos >= 70 && puntos <=99)
        {
            return "Aprobado";
        }
        else if (puntos >= 1 && puntos <= 69)
        {
            return "Reprobado";
        }
        else
        {
            return "Sin estado";
        }
    }
}