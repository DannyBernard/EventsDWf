using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
	[Serializable]
	public class ReservaDetalle
	{
		[Key]
		public int ReservaDetalleId { get; set; }
		public int ReservaID { get; set; }
		public string Nombre { get; set; }
		public int NumeroMesa { get; set; }
		public int Cantidad { get; set; }
		public decimal Precio { get; set; }
	

		

		[ForeignKey("ReservaID")]
		public Reserva Reserva { get; set; }

		public ReservaDetalle(int reservaDetalleId, int reservaID,string nombre ,int numeroMesa,int cantidad, decimal precio) { 
			ReservaDetalleId = reservaDetalleId;
			Nombre = nombre;
            ReservaID = reservaID;
			NumeroMesa = numeroMesa;
			Cantidad = cantidad;
			Precio = precio;
			Nombre = nombre;
	
		}

		public ReservaDetalle()
		{
			ReservaDetalleId = 0;
			ReservaID = 0;
			Nombre = "";
			NumeroMesa = 0;
			Cantidad = 0;
			Precio = 0;
			
		}

	}
}
