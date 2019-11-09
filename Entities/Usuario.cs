using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
	[Serializable]
	public class Usuario
	{
		[Key]
		public int UsuarioID { get; set; }
		public string User  { get; set; }
		public string Password  { get; set; }
		public char Tipo { get; set; }

		public Usuario()
		{
			UsuarioID = 0;
			User = string.Empty;
			Password = string.Empty;
			Tipo = '0';
		}

		public Usuario(int usuarioID, string user, string password, char tipo)
		{
			UsuarioID = usuarioID;
			User = user;
			Password = password;
			Tipo = tipo;
		}
	}
}
