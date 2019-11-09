using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
	public class RepositorioReserva : RepositorioBase<Reserva>
	{
		public override Reserva Buscar(int id)
		{
			Reserva reserva = new Reserva();
			Contexto contexto = new Contexto();
			try
			{
				reserva = contexto.reservas.Include(x => x.Detalle).Where(x => x.ReservaId == id).FirstOrDefault();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				contexto.Dispose();
			}
			return reserva;
		}

		public override bool Modificar(Reserva reserva)
		{
			var Anterior = Buscar(reserva.ReservaId);
			bool paso = false;

			try
			{
				using (Contexto contexto = new Contexto())
				{
					foreach (var item in Anterior.Detalle.ToList())
					{
						if (!reserva.Detalle.Exists(d => d.ReservaDetalleId == item.ReservaDetalleId))
						{
							contexto.Entry(item).State = System.Data.Entity.EntityState.Deleted;
						}
					}
					contexto.SaveChanges();
				}
				foreach (var item in reserva.Detalle)
				{
					var estado = item.ReservaDetalleId > 0 ? EntityState.Unchanged : EntityState.Added;
					_contexto.Entry(item).State = estado;
				}
				_contexto.Entry(reserva).State = EntityState.Modified;
				if (_contexto.SaveChanges() > 0)
					paso = true;
			}
			catch
			{ throw; }
			return paso;
		}
	}
}
