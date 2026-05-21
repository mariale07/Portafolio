//EJERCICIO 1 - positivo, negativo o cero

Console.WriteLine("EJERCICIO 1");
Console.WriteLine("=================================");
int num; 
Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());

if (num > 0) {
    Console.WriteLine("El número es positivo.");
} else if (num < 0) {
    Console.WriteLine("El número es negativo.");
} else
{
    Console.WriteLine("El número es cero.");
}

Console.ReadLine();

//EJERCICIO 2 - año bisiesto

Console.WriteLine("=================================");
Console.WriteLine("EJERCICIO 2");
Console.WriteLine("=================================");
int anio;
Console.WriteLine("Ingrese un año: ");
anio = int.Parse(Console.ReadLine());

if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
{
    Console.WriteLine("El año " + anio + " es bisiesto.");
} else
{
    Console.WriteLine("El año " + anio + " no es bisiesto.");
}

Console.ReadLine();

//EJERCICIO 3 - boleto de ornato

Console.WriteLine("=================================");
Console.WriteLine("EJERCICIO 3");
Console.WriteLine("=================================");
double ingreso;
bool multa;
double monto = 0;

Console.WriteLine("Ingrese su ingreso mensual: Q ");
ingreso = double.Parse(Console.ReadLine());

Console.WriteLine("¿Tiene alguna multa? (Responda con true o false)");
multa = bool.Parse(Console.ReadLine());

if (ingreso >= 500 && ingreso <= 1000)
{
monto = multa ? 20 : 10;
}
else if (ingreso >= 1000 && ingreso <= 3000)
{
    monto = multa ? 30 : 15; 
}
else if (ingreso >= 3000 && ingreso >= 60000)
{
    monto = multa ? 100 : 50;
}
else if (ingreso >= 6000 && ingreso <= 9000)
{
    monto = multa ? 150 : 75;
}
else if (ingreso >= 9000 && ingreso <= 12000)
{
    monto = multa ? 200 : 100;
}
else if (ingreso > 12000)
{
    monto = multa ? 300 : 150;
}
else
{
    Console.WriteLine("Ingreso no válido");
    return;
}
Console.WriteLine("El monto a pagar por ornato es: Q " + monto);

//EJERCICIO 4 - maquina de pago de parqueo


Console.WriteLine("=================================");
Console.WriteLine("EJERCICIO 4");
Console.WriteLine("=================================");
int horas;
int pago;
int total;
int vuelto;

Console.WriteLine("Ingrese la cantidad de horas que estuvo estacionado: ");
horas = int.Parse(Console.ReadLine());

total = horas * 10;
Console.WriteLine("Total a pagar: Q" + total);
Console.WriteLine("Ingrese el monto con el que pagará: ");
pago = int.Parse(Console.ReadLine());

if (pago<total)
{
    Console.WriteLine("Error: El monto ingresado es insuficiente.");
    return;
}
else if (pago == total)
{
    Console.WriteLine("Pago exacto. No se requiere cambio.");
    return;
}
else
{
    vuelto = pago - total;
    Console.WriteLine("Su vuelto es: Q" + vuelto);

    int b100 = vuelto / 100;
    vuelto %= 100; //Comentario para mi: se coloca el signo igual para guardar el resultado dentro de la variable

    int b50 = vuelto / 50;
    vuelto %= 50;

    int b20 = vuelto / 20;
    vuelto %= 20;

    int b10 = vuelto / 10;
    vuelto %= 10;

    int b5 = vuelto / 5;
    vuelto %= 5;

    int b1 = vuelto;

    Console.WriteLine("Billetes entregados:");
    Console.WriteLine("Q100: " + b100);
    Console.WriteLine("Q50: " + b50);
    Console.WriteLine("Q20: " + b20);
    Console.WriteLine("Q10: " + b10);
    Console.WriteLine("Q5: " + b5);
    Console.WriteLine("Q1: " + b1);
}
Console.ReadLine();