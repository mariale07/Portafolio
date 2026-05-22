using System;
namespace L14_MAMP_1155326
{
	public class Estudiante
	{
		public string nombre;
		public int edad;
		public string grado;
		public decimal[] notas;

		public Estudiante(string nombre, int edad, string grado, decimal[] notas)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.grado = grado;
			this.notas = notas; 
		}


		public decimal calcularPromedio()
		{
			decimal suma = 0;

			for(int i = 0; i < notas.Length; i++)
			{
				suma = suma + notas[i];
			}
			decimal promedio = suma / notas.Length;

			return promedio;
		}

		public void mostrarInformacion()
		{
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Edad: " + edad);
			Console.WriteLine("Grado: " + grado);

			Console.WriteLine("Notas: ");

			for (int i = 0; i < notas.Length; i++)
			{
				Console.WriteLine(notas[i] + " ");
			}
			Console.WriteLine("Promedio: " + calcularPromedio());
		}

		public void aprobar()
		{
			if (calcularPromedio() >= 61)
			{
				Console.WriteLine("El estudiante " + nombre + " aprobó");
			}
			else
			{
				Console.WriteLine("El estudiante " + nombre + " reprobó");
			}
		}

		public void agregarNota(decimal nuevaNota)
		{
			decimal[] nuevasNotas = new decimal[notas.Length + 1];
			for (int i=0; i < notas.Length; i++)
			{
				nuevasNotas[i] = notas[i];
			}
			nuevasNotas[nuevasNotas.Length - 1] = nuevaNota;
			notas = nuevasNotas;
			Console.WriteLine("Nueva nota agregada: " + nuevaNota);
		}
	}
}

