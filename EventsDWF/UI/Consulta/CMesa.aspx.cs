using BLL;
using Entities;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDWF.UI.Consulta
{
	public partial class CMesa : System.Web.UI.Page
	{
		static List<Mesa> lista = new List<Mesa>();
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

			Expression<Func<Mesa, bool>> filtro = x => true;
			RepositorioBase<Mesa> repositorio = new RepositorioBase<Mesa>();
			int id;
			switch (BuscarPorDropDownList.SelectedIndex)
			{
				case 0://Todo
					filtro = x => true;
					break;
				case 1://ID
					id = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.MesaId == id;
					break;
				case 2:// Numero
					int num = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.CantidadPersonas == num;
					break;
				case 3:// 
					int ctn = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.CantidadPersonas == ctn;
					break;

			}
			DateTime desdeTextBox = Utilitarios.Utils.ToDateTime(DesdeTextBox.Text);
			DateTime FechaHasta = Utilitarios.Utils.ToDateTime(HastaTextBox.Text);
			if (fechaCheckBox.Checked)
				lista = repositorio.GetList(filtro).Where(c => c.Fecha.Date >= desdeTextBox && c.Fecha.Date <= FechaHasta).ToList();
			else
				lista = repositorio.GetList(filtro);
			this.BindGrid(lista);
		}

		private void BindGrid(List<Mesa> lista)
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
			ReportMesa.ProcessingMode = ProcessingMode.Local;
			ReportMesa.Reset();
			ReportMesa.LocalReport.ReportPath = Server.MapPath(@"\Reportes\ReporteMesa.rdlc");
			ReportMesa.LocalReport.DataSources.Clear();
			ReportMesa.LocalReport.DataSources.Add(new ReportDataSource("ReporteMesa", Metodo.SegMesa()));
			ReportMesa.LocalReport.Refresh();
		}
	}
}
