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
	public partial class CUsuario : System.Web.UI.Page
	{
		static List<Usuario> lista = new List<Usuario>();
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
			Expression<Func<Usuario, bool>> filtro = x => true;
			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			int id;
			switch (BuscarPorDropDownList.SelectedIndex)
			{
				case 0://Todo
					filtro = x => true;
					break;
				case 1://ID
					id = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
					filtro = c => c.UsuarioID == id;
					break;
				case 2:// nombre
					filtro = c => c.Nombre.Contains(FiltroTextBox.Text);
					break;
				case 3:// nombre
					filtro = c => c.Email.Contains(FiltroTextBox.Text);
					break;
				case 4:// nombre
					filtro = c => c.User.Contains(FiltroTextBox.Text);
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

		private void BindGrid(List<Usuario> lista)
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
			ReportUsuario.ProcessingMode = ProcessingMode.Local;
			ReportUsuario.Reset();
			ReportUsuario.LocalReport.ReportPath = Server.MapPath(@"\Reportes\ReporteUsuario.rdlc");
			ReportUsuario.LocalReport.DataSources.Clear();
			ReportUsuario.LocalReport.DataSources.Add(new ReportDataSource("ReporteUsuario",Metodo.SegUsuario()));
			ReportUsuario.LocalReport.Refresh();
		}
	}


	}	

	
