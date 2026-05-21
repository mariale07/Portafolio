using System;
using L14_MAMP_1155326;

class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("----------EJERCICIO 1----------");
        Console.WriteLine();

        CuentaBancaria cuenta1 = new CuentaBancaria("Alejandra", "00125", 4000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Luis", "00948", 5000);

        Console.WriteLine("Información inicial: ");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones de cuenta 1");
        cuenta1.depositar(1000);
        cuenta1.retirar(3000);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones de cuenta 2");
        cuenta2.depositar(500);
        cuenta2.retirar(1500);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Información final:");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("-------------------------------");


        //EJERCICIO 2

        Console.WriteLine("----------EJERCICIO 2----------");
        Console.WriteLine();

        Producto producto1 = new Producto("Cereal", 5000, 15);
        Producto producto2 = new Producto("Manzana", 1500, 10);

        Console.WriteLine("Información inicial: ");
        producto1.mostrarInformacion();
        producto2.mostrarInformacion();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones producto 1: ");
        producto1.vender(4);
        producto1.reabastecer(8);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Operaciones producto 2");
        producto2.vender(9);
        producto2.reabastecer(3);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Información final");
        producto1.mostrarInformacion();
        producto2.mostrarInformacion();
        Console.WriteLine("-------------------------------");

        //EJERCICIO 3

        Console.WriteLine("----------EJERCICIO 3----------");
        Console.WriteLine();

        decimal[] notas1 = { 89, 43, 67 };
        decimal[] notas2 = { 50, 99, 64 };
        Estudiante estudiante1 = new Estudiante("Alejandra", 18, "5to. Bach", notas1);
        Estudiante estudiante2 = new Estudiante("Cristian", 16, "4to. Bach", notas2);

        Console.WriteLine("Información inicial: ");

        estudiante1.mostrarInformacion();
        estudiante2.mostrarInformacion();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Resultados: ");

        estudiante1.aprobar();
        estudiante2.aprobar();
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Agregar nueva nota: ");

        estudiante1.agregarNota(90);
        Console.WriteLine("-------------------------------");

        Console.WriteLine("Datos actualizados: ");
        estudiante1.mostrarInformacion();
        estudiante1.aprobar();
        Console.WriteLine("-------------------------------");

        Console.ReadKey();
    }
}