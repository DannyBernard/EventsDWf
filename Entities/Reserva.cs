using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	[Serializable]
	public class Reserva
	{
		[Key]
		public int ReservaId{ get; set; }
		public string Nombre { get; set; }
		public DateTime Fecha { get; set; }
		public string Usuario { get; set; }
		public decimal Total  { get; set; }
		public int NumeroMesa { get; set; }

		public virtual List<ReservaDetalle> Detalle { get; set; }

		public Reserva()
		{
			ReservaId = 0;
			Nombre = string.Empty;
			Fecha = DateTime.Now;
			Usuario = string.Empty;
			Total = 0;
			NumeroMesa = 0;
			Detalle = new List<ReservaDetalle>();
		}

		public Reserva(int reservaId, string nombre, DateTime fecha, string usuario, decimal total, int numeroMesa,List<ReservaDetalle> detalle)
		{
			ReservaId = reservaId;
			Nombre = nombre;
			Fecha = fecha;
			Usuario = usuario;
			Total = total;
			NumeroMesa = numeroMesa;
			this.Detalle = detalle;	}

		public void AgregarDetalle(int reservaDetalleId, int reservaID, int mesaId, int cantidad, decimal precio, DateTime fecha)
		{
			this.Detalle.Add(new ReservaDetalle( reservaDetalleId,reservaID, mesaId, cantidad, precio, fecha));
		}

		public void RemoveDetalle(int Idex)
		{
			this.Detalle.RemoveAt(Idex);
		}
	}
}
