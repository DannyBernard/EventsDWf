using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Mesa> Mesas { get; set; }
		public DbSet<Reserva> reservas{ get; set; }

		public Contexto() : base("ConStr")
		{

		}
	}
}
