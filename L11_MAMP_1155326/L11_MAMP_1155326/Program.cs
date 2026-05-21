using System;
using System.ComponentModel;

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
        Console.WriteLine();
        Console.WriteLine("--------------Ejercicio 1--------------");
        Console.WriteLine();
        Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        bool palindromo = true; //Se asumirá que es verdadero
        int longitud = palabra.Length; //cuenta las letras

        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - 1 - i]) //Sirve para comparar la primera letra y recorrer desde atras para comparar la última
            {
                palindromo = false;
            }
        }

        if (palindromo == true)
        {
            Console.WriteLine("Es un palíndromo");
        } else
        {
            Console.WriteLine("No es un palíndromo");
        }

        //EJERCICIO 2
        Console.WriteLine();
        Console.WriteLine("--------------Ejercicio 2--------------");
        Console.WriteLine();
        //arreglos
        string[] espanol = { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] ingles = { "red", "blue", "yellow", "white", "green" };
        string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

        int opcion;

        //menú
        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1. Practicar lección");
            Console.WriteLine("2. Terminar lección");
            Console.WriteLine("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese una palabra en español: ");
                string palabras = Console.ReadLine().ToLower();

                bool encontrada = false; //es falsa porque aun no se ha buscado

                for (int i = 0; i < espanol.Length; i++)
                {
                    if (palabras == espanol[i]) //Recorre el arreglo
                    {
                        Console.WriteLine("Ingles: " + ingles[i]);
                        Console.WriteLine("Italiano: " + italiano[i]);
                        encontrada = true;
                    }
                }
                if (encontrada == false) //Si el valor de encontrada sigue siendo falso
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Palabra no encontrada");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        while (opcion != 2); //Cierra el programa
        Console.WriteLine("Lección finalizada");


        //EJERCICIO 3
        Console.WriteLine();
        Console.WriteLine("--------------Ejercicio 3--------------");
        Console.WriteLine();
        //arreglo
        int[] calificaciones = new int[10];
        Random random = new Random();

        for (int i =0;  i < calificaciones.Length; i++)
        {
            calificaciones[i] = random.Next(50, 101);
        }
        int opciones;

        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1. Reporte de rendimiento");
            Console.WriteLine("2. Estadísticas");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Seleccione una opción: ");
            opciones = int.Parse(Console.ReadLine());

            if (opciones == 1)
            {
                Console.WriteLine("Reporte");
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    int nota = calificaciones[i];
                    if (nota >= 50 && nota <= 64)
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    else if (nota >= 65 && nota <= 79)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(nota);
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (opciones == 2)
            { 
                int suma = 0;
                int mayor = calificaciones[0];
                int menor = calificaciones[0];

                for (int i = 0; i < 10; i++)
                {
                    suma = suma + calificaciones[i];
                    if (calificaciones[i] > mayor)
                        mayor = calificaciones[i];
                    if (calificaciones[i] < menor)
                        menor = calificaciones[i];
                }
                double promedio = suma / 10;

                Console.WriteLine("Estadísticas");
                Console.WriteLine();
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Nota más alta: " + mayor);
                Console.WriteLine("Nota más baja: " + menor);
                Console.WriteLine();

            }
        } while (opciones != 3);
        Console.WriteLine("Programa finalizado");

        //EJERCICIO 4
        Console.WriteLine();
        Console.WriteLine("--------------Ejercicio 4--------------");
        Console.WriteLine();
        //arreglos
        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] salario_X_hora = {100, 125.50, 98.65, 125, 132.50, 102.50};
        double[] horas_laboradas = new double[6];

        //Para que ingrese las horas
        for (int i = 0; i <6; i++)
        {
            Console.WriteLine("Ingrese horas trabajadas de " + nombres[i] + ":");
            horas_laboradas[i] = double.Parse(Console.ReadLine());
        }

        double[] pagos = CalcularPagos(horas_laboradas, salario_X_hora);

        MostrarResultados(nombres, pagos);

    }

    static double[] CalcularPagos(double[] horas_laboradas, double[] salario_X_hora)
    {
        double[] pagos = new double[6];

        for (int i= 0; i < 6; i++)
        {
            if (horas_laboradas[i] <= 40)
            {
                pagos[i] = horas_laboradas[i] * salario_X_hora[i];
            }

            else
            {
                double extras = horas_laboradas[i] - 40;
                pagos[i] = (40 * salario_X_hora[i]) + (extras * salario_X_hora[i] * 1.5);
            }
        }
        return pagos;
    }

    static void MostrarResultados(string[] nombres, double[] pagos)
    {
        Console.WriteLine("Pagos Semanales");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(nombres[i] + ", el salario es de Q" + pagos[i]);
        }
    }
}