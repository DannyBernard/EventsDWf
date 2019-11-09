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
		public int MesaId { get; set; }
		public int Cantidad { get; set; }
		public decimal Precio { get; set; }
		public DateTime Fecha { get; set; }

		

		[ForeignKey("ReservaID")]
		public Reserva Reserva { get; set; }

		public ReservaDetalle(int reservaDetalleId, int reservaID, int mesaId, int cantidad, decimal precio, DateTime fecha) { 
			ReservaDetalleId = reservaDetalleId;
			ReservaID = reservaID;
			MesaId = mesaId;
			Cantidad = cantidad;
			Precio = precio;
			Fecha = fecha;
	
		}

		public ReservaDetalle()
		{
			ReservaDetalleId = 0;
			ReservaID = 0;
			MesaId = 0;
			Cantidad = 0;
			Precio = 0;
			Fecha = DateTime.Now;
		
		}

	}
}
