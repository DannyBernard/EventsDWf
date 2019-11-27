using BLL;
using Entities;
using EventsDWF.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDWF.UI
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			Usuario user = new Usuario();
			RLogin login = new RLogin();

			if (Usertext.Text.Length > 0 && pwdText.Text.Length > 0)
			{


				if (login.Auntenticar(Usertext.Text, pwdText.Text))
				{
					FormsAuthentication.RedirectFromLoginPage(user.Email, true);
				}
				else
					Utils.ShowToastr(this.Page, "Usuario o contraseña Incorrecta", "Error", "error");
			}
			else
				Utils.ShowToastr(this.Page, "Debe ingresar su usuario y contraseña", "Error", "error");
		}
	}
	}
