using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class RLogin : RepositorioBase<Usuario>
	{
		private List<Usuario> Listar(Expression<Func<Usuario, bool>> expression)
		{
			List<Usuario> Lista = new List<Usuario>();
			try
			{
				Lista = _contexto.Set<Usuario>().Where(expression).ToList();
			}
			catch (Exception)
			{
				throw;
			}
			return Lista;
		}


		public bool Auntenticar(string usuario, string contraseña)
		{

			Expression<Func<Usuario, bool>> filtrar = x => true;
			filtrar = t => t.Email.Equals(usuario) && t.Password.Equals(contraseña);
			bool paso = false;
			if (Listar(filtrar).Count() != 0)
			{

				paso = true;
			}
			return paso;
		}
	}
}

