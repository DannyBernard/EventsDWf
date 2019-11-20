using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	[Serializable]
	public class Mesa
	{
	  [Key]
		public int MesaId { get; set; }
		public int NumeroMesa { get; set; }
		public int CantidadPersonas { get; set; }
		public decimal Precio  { get; set; }
		public int Cantidad { get; set; }
		public DateTime Fecha { get; set; }

		public Mesa()
		{
			MesaId = 0;
			NumeroMesa = 0;
			CantidadPersonas = 0;
			Precio = 0;
			Cantidad = 0;
			Fecha = DateTime.Now;
		}

		public Mesa(int mesaId, int numeroMesa, int cantidadPersonas,decimal precio,int cantidad, DateTime fecha )
		{
			MesaId = mesaId;
			NumeroMesa = numeroMesa;
			CantidadPersonas = cantidadPersonas;
			Precio = precio;
			Cantidad = cantidad;
			Fecha = fecha;
		}
	}
}
