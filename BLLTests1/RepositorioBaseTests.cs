using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BLL.Tests
{
	[TestClass()]
	public class RepositorioBaseTests
	{
		[TestMethod()]
		public void GuardarTest()
		{
			Usuario usuario = new Usuario();
			usuario.User = "DannyB";
			usuario.Nombre = "Danny Bernard";
			usuario.Password = "d1212";
			usuario.Email = "DB@hotmail.com";
			usuario.Tipo = 'a';
			usuario.Fecha = DateTime.Now;
			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			Assert.IsTrue(repositorio.Guardar(usuario));
			//Mesa
			Mesa mesa = new Mesa();
			mesa.CantidadPersonas = 5;
			mesa.Precio = 120;
			usuario.Fecha = DateTime.Now;
			RepositorioBase<Mesa> repositorio1 = new RepositorioBase<Mesa>();
			Assert.IsTrue(repositorio1.Guardar(mesa));
			//Reserva
			Reserva reserva = new Reserva();
			reserva.Nombre = "Danny";

			RepositorioBase<Reserva> repositorio2 = new RepositorioBase<Reserva>();
			Assert.IsTrue(repositorio2.Guardar(reserva));


		}

		[TestMethod()]
		public void ModificarTest()
		{
			Usuario usuario = new Usuario();
			usuario.UsuarioID = 1;
			usuario.User = "DannyBE";
			usuario.Nombre = "Danny Bernard";
			usuario.Password = "d1215";
			usuario.Email = "Db@hotmail.com";
			usuario.Tipo = 'u';
			usuario.Fecha = DateTime.Today;
			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			Assert.IsTrue(repositorio.Modificar(usuario));
			//Mesa
			Mesa mesa = new Mesa();
			mesa.MesaId = 1;
			mesa.CantidadPersonas = 6;
			mesa.Precio = 120;
			usuario.Fecha = DateTime.Now;
			RepositorioBase<Mesa> repositorio1 = new RepositorioBase<Mesa>();
			Assert.IsTrue(repositorio1.Modificar(mesa));

			Reserva reserva = new Reserva();
			reserva.ReservaId = 1;
			reserva.Nombre = "Danny";
			mesa.Fecha = DateTime.Today;
			RepositorioBase<Reserva> repositorio2 = new RepositorioBase<Reserva>();
			Assert.IsTrue(repositorio2.Modificar(reserva));
		}

		[TestMethod()]
		public void BuscarTest()
		{
			int id = 1;
			Usuario usuario = new Usuario();
			RepositorioBase<Usuario> repositorioBase = new RepositorioBase<Usuario>();
			usuario = repositorioBase.Buscar(id);
			Assert.AreEqual(true, usuario != null);

			int idm = 1;
			Mesa mesa = new Mesa();
			RepositorioBase<Mesa> repositorioBase1 = new RepositorioBase<Mesa>();
			mesa = repositorioBase1.Buscar(id);
			Assert.AreEqual(true, mesa != null);

			int idr = 1;
			Reserva reserva = new Reserva();
			RepositorioBase<Reserva> repositorioBase2 = new RepositorioBase<Reserva>();
			reserva = repositorioBase2.Buscar(id);
			Assert.AreEqual(true, usuario != null);
		}

		[TestMethod()]
		public void GuardarTest1()
		{
			Assert.Fail();
		}
	}
}