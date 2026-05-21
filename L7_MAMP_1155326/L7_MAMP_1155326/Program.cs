//Entrada de usuario
Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine();
//Salida de datos
Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
Console.ReadLine();

Console.WriteLine("EJERCICIO 1 - WHILE");
Console.WriteLine("-------------------");
//Mostrar los números del 1 al 20.
string nom = "Maria Alejandra Montoya Pineda";
int carnet = 1155326;
int indice = 1;

Console.WriteLine("Nombre: " + nom + " | Carnet: " + carnet.ToString());

while (indice <= 20)
{

    if (indice % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    Console.WriteLine(indice);
    indice = indice + 1;
}
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();

Console.WriteLine("------------------------");
Console.WriteLine("EJERCICIO 2 - Do-WHILE");
Console.WriteLine("------------------------");

int num;
int i = 1;

Console.WriteLine("Ingrese un número entero positivo: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine("Los divisores de " + num + " serían: ");

do
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
} while (i <= num);
Console.ReadLine();

Console.WriteLine("------------------------");
Console.WriteLine("EJERCICIO 3 - FOR");
Console.WriteLine("------------------------");

int n;
Console.WriteLine("Ingrese la cantidad de números de Fibonacci que desea: ");
n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int proximo;

Console.WriteLine("La serie de Fibonnacci es: ");

for(int x = 1; x <= n; x++)
{
    Console.WriteLine(a);

    proximo = a + b;
    a = b;
    b = proximo;
}
Console.ReadLine();

Console.WriteLine("------------------------");
Console.WriteLine("EJERCICIO 3 - CICLOS ANIDADOS");
Console.WriteLine("------------------------");

for (int m = 1; m<=12; m++)
{
    Console.WriteLine("Tabla de multiplicar del " + m);
    for (int l = 1; l <= 10; l++)
    {
        int resultado = m * l;
        Console.WriteLine(m + " x " + l + " = " + resultado);
    }
    Console.WriteLine();
}
Console.ReadLine();