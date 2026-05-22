Console.WriteLine("PROBLEMA 3");
Console.WriteLine("===============");
int opcion;
double temp, resultado;

Console.WriteLine("Seleccione una opción (1-3): ");
Console.WriteLine("Opción 1: Celsius a Farenheit");
Console.WriteLine("Opción 1: Farenheit a Celsius");
Console.WriteLine("Opción 1: Celsius a Kelvin");
opcion = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura: ");
temp = double.Parse(Console.ReadLine());

if (opcion == 1)
{
    resultado = (temp * 9 / 5) + 32;
    Console.WriteLine("La temperatura es: " + resultado + "°F");
}
else if (opcion == 2)
{
    resultado = (temp - 32) * 5 / 9;
    Console.WriteLine("La temperatura es: " + resultado + "°C");
}
else if (opcion == 3)
{
    resultado = temp + 273.15;
    Console.WriteLine("La temperatura es: " + resultado + "K");
}
else
{
    Console.WriteLine("La opción no es compatible.");
}
Console.ReadLine();

Console.WriteLine("===============");
Console.WriteLine("PROBLEMA 4");
Console.WriteLine("===============");
string tipo_sangre;

Console.WriteLine("Ingrese el tipo de sangre del paciente (indique si es positivo o negativo): ");
tipo_sangre = Console.ReadLine();

if (tipo_sangre == "AB")
{
    Console.WriteLine("Puede recibir todos los tipos de sangre.");
}
else if (tipo_sangre == "AB-")
{
    Console.WriteLine("Puede recibir sangre tipo: O-, B-, A- y AB-");
}
else if (tipo_sangre == "A+")
{
    Console.WriteLine("Puede recibir sangre tipo: O-, O+, A- y A+");
}
else if (tipo_sangre == "A-")
{
    Console.WriteLine("Puede recibir sangre tipo: O- y A-");
}
else if (tipo_sangre == "B+")
{
    Console.WriteLine("Puede recibir sangre tipo: O-, O+, B- y B+");
}
else if (tipo_sangre == "B-")
{
    Console.WriteLine("Puede recibir sangre tipo: O- y B-");
}
else if (tipo_sangre == "O+")
{
    Console.WriteLine("Puede recibir sangre tipo: O- y O+");
}
else if (tipo_sangre == "O-")
{
    Console.WriteLine("Puede recibir sangre tipo: O-");
}
else
{
    Console.WriteLine("El tipo de sangre ingresado no es válido.");
}
Console.ReadLine();