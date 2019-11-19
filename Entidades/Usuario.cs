using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
	[Serializable]
	public class Usuario
	{
		[Key]
		public int UsuarioID { get; set; }
		public string Nombre { set; get; }
		public string User  { get; set; }
		public string Password  { get; set; }
		public string Email { get; set; }
		public char Tipo { get; set; }
		public DateTime Fecha { get; set; }

		public Usuario()
		{
			UsuarioID = 0;
			Nombre = string.Empty;
			User = string.Empty;
			Password = string.Empty;
			Email = string.Empty;
			Tipo = '0';
			Fecha = DateTime.Now;
		}

		public Usuario(int usuarioID,string nombre, string user, string password,string email, char tipo,DateTime fechaCreacion)
		{
			UsuarioID = usuarioID;
			Nombre = nombre;
			User = user;
			Password = password;
			Tipo = tipo;
			Email = email;
			Fecha = fechaCreacion;

		}
	}
}
