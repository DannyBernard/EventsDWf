using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL.Tests
{
	[TestClass()]
	public class RepositorioBaseTests
	{
		[TestMethod()]
		public void GuardarTest()
		{
			Reserva reserva = new Reserva();
			reserva.Nombre = "Danny";

			RepositorioBase<Reserva> repositorio2 = new RepositorioBase<Reserva>();
			Assert.IsTrue(repositorio2.Guardar(reserva));

		}

		[TestMethod()]
		public void ModificarTest()
		{
			Reserva reserva = new Reserva();
			reserva.ReservaId = 1;
			reserva.Nombre = "Danny";
			reserva.Fecha = DateTime.Today;
			RepositorioBase<Reserva> repositorio2 = new RepositorioBase<Reserva>();
			Assert.IsTrue(repositorio2.Modificar(reserva));
		}

		[TestMethod()]
		public void BuscarTest()
		{
			int id = 1;
			Reserva reserva = new Reserva();
			RepositorioBase<Reserva> repositorioBase2 = new RepositorioBase<Reserva>();
			reserva = repositorioBase2.Buscar(id);
			Assert.AreEqual(true, reserva != null);
		}
	}
}