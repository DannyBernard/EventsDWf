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
				FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

			}
		}
		public void LlenaCampo(Mesa mesa)
		{
			IDTexBox.Text = mesa.MesaId.ToString();
			NumeromesaTextBox.Text = mesa.NumeroMesa.ToString();
			CantidadPersonasTextBox.Text = mesa.CantidadPersonas.ToString(); ;
			PrecioTextBox.Text = mesa.NumeroMesa.ToString() ;
			FechaTextBox.Text = mesa.Fecha.ToString("yyyy-MM-dd");
		

		}

		protected Mesa LlenaClase()
		{
			Mesa mesa = new Mesa();
			mesa.MesaId = Utilitarios.Utils.ToInt(IDTexBox.Text);
			mesa.NumeroMesa = Utilitarios.Utils.ToInt(NumeromesaTextBox.Text);
			mesa.CantidadPersonas = Utilitarios.Utils.ToInt(CantidadPersonasTextBox.Text);
			mesa.Cantidad = Utilitarios.Utils.ToInt(CantidadTextBox.Text);
			mesa.Fecha = Utilitarios.Utils.ToDateTime(FechaTextBox.Text);
		

			return mesa;
		}

		protected void Limpiar()
		{
			IDTexBox.Text = "";
			NumeromesaTextBox.Text = "";
			CantidadPersonasTextBox.Text ="";
			PrecioTextBox.Text = "";
			FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
			
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
	}
}