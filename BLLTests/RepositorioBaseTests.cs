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
		}

		[TestMethod()]
		public void BuscarTest()
		{
			int id = 1;
			Usuario usuario = new Usuario();
			RepositorioBase<Usuario> repositorioBase = new RepositorioBase<Usuario>();
			usuario = repositorioBase.Buscar(id);
			Assert.AreEqual(true, usuario != null);
		}

	
	}
}