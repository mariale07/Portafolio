// Entrada de usuario
Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine();
//Salida de datos
Console.WriteLine("Hola " + nombre + " ¡Bienvenido a C#!");
Console.ReadLine();
Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 1");
Console.WriteLine("--------------------------------");
int num;
int suma = 0;
Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());
int mayor = num;
int menor = num;
suma = num;
for (int i = 2; i <= 20; i++)
{
    Console.WriteLine("Ingrese otro número: ");
    num = int.Parse(Console.ReadLine());
    if (num > mayor)
    {
        mayor = num;
    }
    else if (num < menor)
    {
        menor = num;
    }
    suma = suma + num;
}
double promedio = suma / 20;
Console.WriteLine("El número mayor es: " + mayor);
Console.WriteLine("El número menor es: " + menor);
Console.WriteLine("El promedio es: " + promedio);
Console.ReadLine();

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 2");
Console.WriteLine("--------------------------------");
for (int j = 1; j <= 100; j++)
{
    if (j % 2 == 0 && j % 7 == 0)
    {
        Console.WriteLine(j + " = ParSiete");
    }
    else if (j % 2 == 0)
    {
        Console.WriteLine(j + " = Par");
    }
    else if (j % 7 == 0)
    {
        Console.WriteLine(j + " = Siete");
    }
    else
    {
        Console.WriteLine(j + " = No es múltiplo de 2 ni de 7.");
    }
}
Console.ReadLine();

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 3");
Console.WriteLine("--------------------------------");
int cliente_descuento = 0;
double total_ventas = 0;

for (int a = 1; a <= 10; a++)
{
    Console.WriteLine("Ingrese el monto de compra del cliente: ");
    double compra = double.Parse(Console.ReadLine());

    double descuento = 0;
    double total_pagar;

    if (compra > 300)
    {
        descuento = compra * 0.05;
        cliente_descuento++;
    }
    else if (compra > 700)
    {
        descuento = compra * 0.12;
        cliente_descuento++;
    }
    total_pagar = compra - descuento;
    Console.WriteLine("El total a pagar del cliente " + a + ": " + total_pagar);
    total_ventas = total_ventas + total_pagar;
}
Console.WriteLine("Clientes con descuento: " + cliente_descuento);
Console.WriteLine("Total de ventas del día: " + total_ventas);
Console.ReadLine();

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 4");
Console.WriteLine("--------------------------------");

Console.WriteLine("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Las opciones son: ");
Console.WriteLine("1. Mostrar los números desde el número ingresado hasta 1");
Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el número ingresado");
Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el número ingresado");
Console.WriteLine("Ingrese la opción: ");

int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("=========================");

if (opcion == 1)
{
    int b = numero;
    while (b >= 1)
    {
        Console.WriteLine(b);
        b--;
    }
}
else if (opcion == 2)
{
    int b = 1;
    while (b <= numero)
    {
        if (b % 3 == 0)
        {
            Console.WriteLine(b);
        }
        b++;
    }
}
else if (opcion == 3)
{
    int b = 1;
    while (b <= numero)
    {
        if (b % 5 == 0)
        {
            Console.WriteLine(b);
        }
        b++;
    }
}
else
{
    Console.WriteLine("Opción no válida.");
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio 5");
Console.WriteLine("--------------------------------");

Console.WriteLine("Ingrese el número de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("=========================");

for (int c=1; c<= filas; c++)
{
    for (int d = 1; d <= c; d++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}