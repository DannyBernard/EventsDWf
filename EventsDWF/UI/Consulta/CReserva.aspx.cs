using BLL;
using Entities;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDWF.UI.Consulta
{
	public partial class CReserva : System.Web.UI.Page
	{
		static List<Reserva> lista = new List<Reserva>();
		protected void Page_Load(object sender, EventArgs e)
		{
			DesdeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
			HastaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
			if (!Page.IsPostBack)
			{
				LlenaReport();
			}
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			Expression<Func<Reserva, bool>> filtro = x => true;
			RepositorioBase<Reserva> repositorio = new RepositorioBase<Reserva>();
			int id;
			switch (BuscarPorDropDownList.SelectedIndex)
			{
				case 0://Todo
					filtro = x => true;
					break;
				case 1://ID
					id = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.ReservaId == id;
					break;
				case 2:// Nombre
					filtro = c => c.Nombre.Contains(FiltroTextBox.Text);

					break;
				case 4:// 
					decimal precio = Utilitarios.Utils.ToDecimal(FiltroTextBox.Text);
					filtro = c => c.Monto == precio;
					break;
				case 3:// 
					int combo = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.MesaID == combo;
					break;
				//	this.BindGrid(lista);
			}
			//this.BindGrid(lista);
			DateTime desdeTextBox = Utilitarios.Utils.ToDateTime(DesdeTextBox.Text);
			DateTime FechaHasta = Utilitarios.Utils.ToDateTime(HastaTextBox.Text);
		
			if (fechaCheckBox.Checked)
				lista = repositorio.GetList(filtro).Where(c => c.Fecha.Date >= desdeTextBox && c.Fecha.Date <= FechaHasta).ToList();

			
				lista = repositorio.GetList(filtro);
			
		  this.BindGrid(lista);

		}
		private void BindGrid(List<Reserva> lista)
		{
			DatosGridView.DataSource = lista;
			DatosGridView.DataBind();
		}


		protected void fechaCheckBox_CheckedChanged1(object sender, EventArgs e)
		{
			if (fechaCheckBox.Checked)
			{
				fechaCheckBox.Visible = true;
				fechaCheckBox.Visible = true;
			}
			else
			{
				fechaCheckBox.Visible = false;
				fechaCheckBox.Visible = false;
			}
		}
		public void LlenaReport()
		{
			ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "Popup", $"ShowReporte('');", true);
			ReportReserva.ProcessingMode = ProcessingMode.Local;
			ReportReserva.Reset();
			ReportReserva.LocalReport.ReportPath = Server.MapPath(@"\Reportes\ReporteReserva.rdlc");
			ReportReserva.LocalReport.DataSources.Clear();
			ReportReserva.LocalReport.DataSources.Add(new ReportDataSource("ReporteReserva", Metodo.SegReserva()));
			ReportReserva.LocalReport.Refresh();
		}
	}

}
