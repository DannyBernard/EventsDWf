using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDWF.UI.Registros
{
	public partial class RMesas : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				FechaLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");

			}
		}
		public void LlenaCampo(Mesa mesa)
		{
			IDTexBox.Text = mesa.MesaId.ToString();
			
			CantidadPersonasTextBox.Text = mesa.CantidadPersonas.ToString(); ;
			PrecioTextBox.Text = mesa.Precio.ToString();
			//FechaLabel.Text = mesa.Fecha.ToString("yyyy-MM-dd");


		}

		protected Mesa LlenaClase()
		{
			Mesa mesa = new Mesa();
			mesa.MesaId = Utilitarios.Utils.ToInt(IDTexBox.Text);
			mesa.Precio = Utilitarios.Utils.ToDecimal(PrecioTextBox.Text);
			mesa.CantidadPersonas = Utilitarios.Utils.ToInt(CantidadPersonasTextBox.Text);
			mesa.Cantidad = Utilitarios.Utils.ToInt(CantidadTextBox.Text);
			mesa.Fecha = Utilitarios.Utils.ToDateTime(FechaLabel.Text);


			return mesa;
		}

		protected void Limpiar()
		{
			IDTexBox.Text = "";
		
			CantidadPersonasTextBox.Text = "";
			PrecioTextBox.Text = "";
			FechaLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");

		}


		protected void BuscarButton_Click1(object sender, EventArgs e)
		{
			RepositorioBase<Mesa> repositorio = new RepositorioBase<Mesa>();
			Mesa mesa = repositorio.Buscar(Utilitarios.Utils.ToInt(IDTexBox.Text));
			if (mesa != null)
			{
				LlenaCampo(mesa);
				Utilitarios.Utils.ShowToastr(this.Page, "Busqueda exitosa", "Exito", "success");
			}
			else
			{
				Utilitarios.Utils.ShowToastr(this.Page, "Usuario No Exite", "Error", "warning");
			}
		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{
			RepositorioBase<Mesa> repositorioBase = new RepositorioBase<Mesa>();
			Mesa mesa = LlenaClase();
			bool paso = false;

			if (mesa.MesaId == 0)
				paso = repositorioBase.Guardar(mesa);
			else
				paso = repositorioBase.Modificar(mesa);

			if (paso)
			{
				Utilitarios.Utils.ShowToastr(this, "Guardo con exito", "Exito", "success");
				Limpiar();
			}
			else
			{
				Utilitarios.Utils.ShowToastr(this, "No Guardo", "Error", "warning");
			}
		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{

			RepositorioBase<Mesa> repositorio = new RepositorioBase<Mesa>();
			int id = Utilitarios.Utils.ToInt(IDTexBox.Text);
			var mesa = repositorio.Buscar(id);
			if (mesa == null)
			{
				Utilitarios.Utils.ShowToastr(this, " Usuario no exite", "Error", "warning");
			}
			else
			{
				repositorio.Eliminar(id);
				Utilitarios.Utils.ShowToastr(this, "Elimino con exito", "Exito", "success");
			}
		}
	}
}