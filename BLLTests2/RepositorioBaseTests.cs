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
			Mesa mesa = new Mesa();
			mesa.CantidadPersonas = 5;
			mesa.Precio = 120;
			mesa.Fecha = DateTime.Now;
			RepositorioBase<Mesa> repositorio1 = new RepositorioBase<Mesa>();
			Assert.IsTrue(repositorio1.Guardar(mesa));
		}

		[TestMethod()]
		public void BuscarTest()
		{
			int id = 1;
			Mesa mesa = new Mesa();
			RepositorioBase<Mesa> repositorioBase1 = new RepositorioBase<Mesa>();
			mesa = repositorioBase1.Buscar(id);
			Assert.AreEqual(true, mesa != null);
		}



		[TestMethod()]
		public void ModificarTest()
		{
			Mesa mesa = new Mesa();
			mesa.MesaId = 1;
			mesa.CantidadPersonas = 6;
			mesa.Precio = 120;
			mesa.Fecha = DateTime.Now;
			RepositorioBase<Mesa> repositorio1 = new RepositorioBase<Mesa>();
			Assert.IsTrue(repositorio1.Modificar(mesa));
		}

		
	}
}