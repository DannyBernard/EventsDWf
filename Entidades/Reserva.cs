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
		public int ReservaId { get; set; }
		public string Nombre { get; set; }
		public DateTime Fecha { get; set; }
		public int UsuarioID { get; set; }
        public decimal Total { get; set; }
		public decimal Monto { get; set; }
		public int MesaID { get; set; }


		public virtual List<ReservaDetalle> Detalle { get; set; }

		public Reserva()
		{
			ReservaId = 0;
			Nombre = string.Empty;
			Fecha = DateTime.Now;
			UsuarioID = 0;

			Total = 0;
			Monto = 0;
			MesaID = 0;
			Detalle = new List<ReservaDetalle>();
		}

		public Reserva(int reservaId, string nombre, DateTime fecha, int usuario, decimal total, int mesaID, List<ReservaDetalle> detalle)
		{
			ReservaId = reservaId;
			Nombre = nombre;
			Fecha = fecha;
			UsuarioID = usuario;
			Total = total;
	    	MesaID = mesaID;
			this.Detalle = detalle;
		}

		public void AgregarDetalle(int reservaDetalleId, int reservaID,string Nombre,int numeroMesa, int cantidad, decimal precio, DateTime fecha)
		{
			this.Detalle.Add(new ReservaDetalle(reservaDetalleId, reservaID,Nombre,numeroMesa, cantidad, precio));
		}

		public void RemoveDetalle(int Idex)
		{
			this.Detalle.RemoveAt(Idex);
		}
	}
}
