using System;
namespace L14_MAMP_1155326
{
	public class CuentaBancaria
	{

		public string titular;
		public string numeroCuenta;
		public decimal saldo;

		public CuentaBancaria(string titular, string numeroCuenta, decimal saldo)
		{
			this.titular = titular;
			this.numeroCuenta = numeroCuenta;
			this.saldo = saldo; 
		}

		public void mostrarInformacion()
		{
			Console.WriteLine("Titular: " + titular);
			Console.WriteLine("Número de cuenta: " + numeroCuenta);
			Console.WriteLine("Saldo: Q" + saldo);
		}

		public void depositar (decimal monto)
		{
			Console.WriteLine("Saldo antes del depósito: Q" + saldo);
			saldo = saldo + monto;
			Console.WriteLine("Se depositaron: Q" + monto);
			Console.WriteLine("Saldo después del depósito: Q" + saldo);
		}

		public void retirar (decimal monto)
		{
            Console.WriteLine("Saldo antes del retiro: Q" + saldo);
            if (saldo >= monto)
			{
				saldo = saldo - monto;
                Console.WriteLine("Se retiraron: Q" + monto);
                Console.WriteLine("Saldo después del retiro: Q" + saldo);
            } else
			{
				Console.WriteLine("Fondos insuficientes");
			}
        }
	}
}

