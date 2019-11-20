using BLL;
using Entities;
using EventsDWF.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDWF.UI.Registros
{
	public partial class RReserva : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
			FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
			if (!Page.IsPostBack)
			{
				//si llego in id
				int id = Utils.ToInt(Request.QueryString["id"]);
				if (id > 0)
				{
					RepositorioBase<Reserva> repositorio = new RepositorioBase<Reserva>();
					Reserva reserva = repositorio.Buscar(id);
					if (reserva == null)
						Utils.ShowToastr(this, "Id no existe", "Error", "error");
					else
						LlenarCombo();
					LlenarCampo(reserva);
				}
				LlenarCombo();
				ViewState["Reserva"] = new Reserva();
			}

		}
		protected void BindGrid()
		{
			DatosGridView.DataSource = ((Reserva)ViewState["Reserva"]).Detalle;
			DatosGridView.DataBind();
		}
		private Reserva LlenaClase( )
		{
			Reserva reserva = new Reserva();
			reserva = (Reserva)ViewState["Reserva"];
			reserva.ReservaId = Utils.ToInt(IDTexBox.Text);
			reserva.Nombre = NombreTextBox.Text;
			reserva.MesaID = NumeroMesaDropdownList.SelectedValue.Length;
			reserva.Fecha = DateTime.Now;
			
			reserva.Total = 0;
			
			return reserva;
		}
		private void Limpiar()
		{
			IDTexBox.Text = string.Empty;
			NumeroMesaDropdownList.ClearSelection();
			NumeroTextBox.Text = string.Empty;
			FechaTextBox.Text = DateTime.Now.ToString();
			PrecioTextBox.Text = 0.ToString();
		    ViewState["Reserva"] = new Reserva();
			LlenarCombo();
			this.BindGrid();
		}
		private void LlenarCampo(Reserva reserva)
		{
			Limpiar();
			IDTexBox.Text = reserva.ReservaId.ToString();
			NumeroMesaDropdownList.SelectedValue = reserva.MesaID.ToString();
			PrecioTextBox.Text = reserva.Monto.ToString();
			FechaTextBox.Text = reserva.Fecha.ToString();
			
			ViewState["Reserva"] = reserva;
			//CalcularMonto();
			this.BindGrid();
		}
		private void LlenarCombo()
		{
			
			NumeroMesaDropdownList.Items.Clear();
			NumeroMesaDropdownList.Items.Clear();
			RepositorioBase<Mesa> repositorio = new RepositorioBase<Mesa>();
			NumeroMesaDropdownList.DataSource = repositorio.GetList(x => true);
			NumeroMesaDropdownList.DataValueField = "MesaId";
			NumeroMesaDropdownList.DataTextField = "NumeroMesa";
		    NumeroMesaDropdownList.DataBind();
		


		}
		/**
		public void CalcularMonto()
		{
			decimal Monto = 0;
			int cantidad = 0;
			Reserva reserva = new Reserva();
			reserva = (Reserva)ViewState["Reserva"];
			foreach (var item in reserva.Detalle.ToList())
			{
				Mesa M = new RepositorioBase<Mesa>().Buscar(item.Reserva.MesaID);
				cantidad -= M.Cantidad;
			}
			reserva.Monto = Monto;
			
			
			ViewState["Reserva"] = reserva;
			this.BindGrid();
		}
	*/
		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			RepositorioBase<Reserva> repositorio = new RepositorioBase<Reserva>();
			Reserva reserva = repositorio.Buscar(Utils.ToInt(IDTexBox.Text));
			if (reserva != null)
			{
				LlenarCampo(reserva);
				Utils.ShowToastr(this.Page, "Exito", "Exito", "Exito");
			}
			else
			{
				Limpiar();
				Utils.ShowToastr(this.Page, "Id no exite", "Error", "error");
			}
		}
		
		protected void AddButton_Click(object sender, EventArgs e)
		{
			decimal total =0;
			int totalc=0;
			Reserva reserva = new Reserva();
			reserva = (Reserva)ViewState["Reserva"];
			reserva.AgregarDetalle(0, Utils.ToInt(IDTexBox.Text),Utils.ToInt(CantidadTextBox.Text),Utils.ToDecimal(PrecioTextBox.Text),Utils.ToDateTime(FechaTextBox.Text));
			ViewState["Reserva"] = reserva;
			this.BindGrid();

			

			foreach (var item in reserva.Detalle)
			{
				total += item.Precio;
			}
			TotalTextBox.Text = total.ToString();

			foreach (var item in reserva.Detalle)
			{
				totalc += item.Cantidad;
			}
			CntTextBox.Text = totalc.ToString();
		}
		int ctn;
		protected void RemoveLinkButton_Click(object sender, EventArgs e)
		{
			if (DatosGridView.Rows.Count > 0 && DatosGridView.SelectedIndex >= 0)
			{
				Reserva reserva = new Reserva();
				reserva = (Reserva)ViewState["Reserva"];
				GridViewRow row = (sender as Button).NamingContainer as GridViewRow;
				reserva.RemoveDetalle(row.RowIndex);
				ViewState["Reserva"] = reserva;
				this.BindGrid();
				//CalcularMonto();
			}

		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{
			RepositorioReserva repositorio = new RepositorioReserva();
			Reserva reserva = repositorio.Buscar(Utils.ToInt(IDTexBox.Text));


			if (reserva == null)
			{
				
				if (repositorio.Guardar(LlenaClase()))
				{
					int cantidad;
					RepositorioBase<Mesa> re = new RepositorioBase<Mesa>();
					Mesa M = new RepositorioBase<Mesa>().Buscar(Utils.ToInt(NumeroMesaDropdownList.SelectedItem.Value));
				    cantidad =	M.Cantidad - Utils.ToInt(CntTextBox.Text);
					M.Cantidad = cantidad;
					re.Modificar(M);
					Utils.ShowToastr(this, "Guardado", "Exito", "success");
					Limpiar();
				}
				else
				{
					Utils.ShowToastr(this, "No existe", "Error", "error");
					Limpiar();
				}

			}
			else
			{
				if (repositorio.Modificar(LlenaClase()))
				{
					Utils.ShowToastr(this.Page, "Modificado con exito!!", "Guardado", "success");
					Limpiar();
				}
				else
				{
					Utils.ShowToastr(this.Page, "No se puede modificar", "Error", "error");
					Limpiar();
				}
			}
		}

		protected void NumeroMesaDropdownList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{
			GridViewRow grid = DatosGridView.SelectedRow;
			RepositorioReserva repositorio = new RepositorioReserva();


			if (IDTexBox.Text == 0.ToString())
			{
				Utils.ShowToastr(this.Page, "Id no exite", "success");
				return;
			}
			if (repositorio.Eliminar(Utils.ToInt(IDTexBox.Text)))
			{
				Utils.ShowToastr(this.Page, "Exito Eliminado", "success");
				Limpiar();
			}
			else
				Utils.ShowToastr(this.Page, "No Elimino", "Erorror");

		}
	}
	}
