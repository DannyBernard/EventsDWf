using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class Metodo
	{

		public static int ToInt(string valor)
		{
			int retorno = 0;
			int.TryParse(valor, out retorno);

			return retorno;
		}

		public static List<Usuario> SegUsuario()
		{
			Expression<Func<Usuario, bool>> filtro = p => true;
			RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
			List<Usuario> list = new List<Usuario>();

			list = repositorio.GetList(filtro);

			return list;
		}

		public static List<Mesa> SegMesa()
		{
			Expression<Func<Mesa, bool>> filtro = p => true;
			RepositorioBase<Mesa> repositorio = new RepositorioBase<Mesa>();
			List<Mesa> list = new List<Mesa>();

			list = repositorio.GetList(filtro);

			return list;
		}
		public static List<ReservaDetalle> SegReserva()
		{
			Expression<Func<ReservaDetalle, bool>> filtro = p => true;
			RepositorioBase<ReservaDetalle> repositorio = new RepositorioBase<ReservaDetalle>();
			List<ReservaDetalle> list = new List<ReservaDetalle>();

			list = repositorio.GetList(filtro);

			return list;
		}

	}
}

