using System;
namespace L14_MAMP_1155326
{
	public class Producto
	{
		public string nombre;
		public decimal precio;
		public int cantidad;

		public Producto(string nombre, decimal precio, int cantidad)
		{
			this.nombre = nombre;
			this.precio = precio;
			this.cantidad = cantidad;
		}

		public void mostrarInformacion()
		{
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Precio: Q" + precio);
			Console.WriteLine("Cantidad disponible: " + cantidad);
		}

		public void vender(int cantidadVendida)
		{
			Console.WriteLine("Cantidad antes de la venta: " + cantidad);

			if (cantidad >= cantidadVendida)
			{
				cantidad = cantidad - cantidadVendida;

				Console.WriteLine("Se vendieron: " + cantidadVendida);
				Console.WriteLine("Cantidad después de la venta: " + cantidad);
			}
			else
			{
				Console.WriteLine("Stock insuficiente");
			}
		}

        public void reabastecer(int cantidadNueva)
        {
            Console.WriteLine("Cantidad antes del reabastecimiento: " + cantidad);

            cantidad = cantidad + cantidadNueva;

            Console.WriteLine("Se agregaron: " + cantidadNueva + "al stock de la tienda.");
            Console.WriteLine("Cantidad después del reabastecimiento: " + cantidad);
        }
    }
}
