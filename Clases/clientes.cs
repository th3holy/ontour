using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
	public class clientes
	{
		private int _id;
		private string _nombre;
		private string _apellido;
		private string _email;
		private int _precio;
		private int _nropersonas;
		private int _total;

		public int TOTAL
		{
			get { return _total; }
			set { _total = value; }
		}


		public int NROPERSONAS
		{
			get { return _nropersonas; }
			set { _nropersonas = value; }
		}


		public int PRECIO
		{
			get { return _precio; }
			set { _precio = value; }
		}

		public string EMAIL
		{
			get { return _email; }
			set { _email = value; }
		}




		public string APELLIDO
		{
			get { return _apellido; }
			set { _apellido = value; }
		}


		public string NOMBRE
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
	}
}
