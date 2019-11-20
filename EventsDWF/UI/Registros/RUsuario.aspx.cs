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
	public partial class RUsuario : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

			}
		}

		public void LlenaCampo(Usuario usuario)
		{
			IDTexBox.Text = usuario.UsuarioID.ToString();
			NombreTextBox.Text = usuario.Nombre;
			UserTextBox.Text = usuario.User;
			PasswordTextBox.Text = usuario.Password;
			EmailTextBox.Text = usuario.Email;
			TipoTextBox.Text = usuario.Tipo.ToString();
			FechaTextBox.Text = usuario.Fecha.ToString("yyyy-MM-dd");

		}

		protected Usuario LlenaClase()
		{
			Usuario usuario = new Usuario();
			usuario.UsuarioID = Utilitarios.Utils.ToInt(IDTexBox.Text);
			usuario.Nombre = NombreTextBox.Text;
			usuario.User = UserTextBox.Text;
			usuario.Email = EmailTextBox.Text;
           usuario.Password = PasswordTextBox.Text;
			usuario.Tipo = Utilitarios.Utils.ToChar(TipoTextBox.Text);
			usuario.Fecha = Utilitarios.Utils.ToDateTime(FechaTextBox.Text);

			return usuario;
		}

		protected void Limpiar()
		{
			IDTexBox.Text = "";
			NombreTextBox.Text = "";
			UserTextBox.Text = "";
			PasswordTextBox.Text = "";
			TipoTextBox.Text = "";
			FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
			EmailTextBox.Text = "";
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			Usuario usuario = repositorio.Buscar(Utilitarios.Utils.ToInt(IDTexBox.Text));
			if (usuario != null)
			{
		     LlenaCampo(usuario);
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
			RepositorioBase<Usuario> repositorioBase = new RepositorioBase<Usuario>();
			Usuario usuario = LlenaClase(); 
			bool paso = false;
			
			if (usuario.UsuarioID == 0)
				paso = repositorioBase.Guardar(usuario);
			else
				paso = repositorioBase.Modificar(usuario);

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

			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			int id = Utilitarios.Utils.ToInt(IDTexBox.Text);
			var usuario = repositorio.Buscar(id);
			if (usuario == null)
			{
				Utilitarios.Utils.ShowToastr(this, " Usuario no exite" ,"Error", "warning");
			}
			else
			{
				repositorio.Eliminar(id);
				Utilitarios.Utils.ShowToastr(this, "Elimino con exito", "Exito", "success");
			}
		}

		
	}
}