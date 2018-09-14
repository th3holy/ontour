using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Clases;
using baseDatos;
using System.Data.Objects;



namespace vistas
{
	/// <summary>
	/// Lógica de interacción para ventas.xaml
	/// </summary>
	public partial class ventas : Window
	{
		clienteventasEntities db = new clienteventasEntities();
		baseDatos.clientes cli = new baseDatos.clientes();
		List<baseDatos.clientes> lista = new List<baseDatos.clientes>();
		
		public ventas()
		{
			InitializeComponent();
			txt_total.IsEnabled = false;
			Limpiar();
			cargar();
		}

		public void Limpiar()
		{
			txt_ApellidoCliente.Text = string.Empty;
			txt_Email.Text = string.Empty;
			txt_NombreCliente.Text = string.Empty;
			txt_NROPersonas.Text = string.Empty;
			txt_Precio.Text = string.Empty;
			txt_total.Text = string.Empty;
			Contrato.Text = string.Empty;
		}
		public void Suma()
		{
			try
			{
				int total;
				total = Convert.ToInt16(txt_Precio.Text) * Convert.ToInt32(txt_NROPersonas.Text);
				txt_total.Text = Convert.ToString(total);

			}
			catch (Exception)
			{
				MessageBox.Show("LOS VALORES DE LA SUMA SON INCORRECTOS O UNO DE LOS CAMPOS ESTAN VACIOS ");
			}
		}

		public void CONTRATO()
		{
			try
			{
				if (txt_ApellidoCliente.Text == string.Empty || txt_NombreCliente.Text == string.Empty || txt_Precio.Text == string.Empty || txt_NROPersonas.Text == string.Empty)
				{
					MessageBox.Show("los campos estan vacios ");
				}
				else
				{
					Contrato.Text = "señor(A) " + txt_NombreCliente.Text + " " + txt_ApellidoCliente.Text +
					" ha hecho una cotizacion avaluada en $" + txt_Precio.Text + " para " + txt_NROPersonas.Text + " personas con un valor ha pagar de " + txt_total.Text;
				}

			}
			catch (Exception)
			{

				MessageBox.Show(" uno de los campos son invalidos o estan en blanco ");
			}
		}

		private void agregar()
		{

			try
			{
				decimal i = ((from clientes in db.clientes
							  select clientes.id).Max()) + 1;
				db.ps_agregarcli(
					++i,
					txt_NombreCliente.Text,
					txt_ApellidoCliente.Text,
					txt_Email.Text,
					int.Parse(txt_Precio.Text),
					int.Parse(txt_NROPersonas.Text),
					int.Parse(txt_total.Text));
			}
			catch (Exception)
			{
				MessageBox.Show("error no esperado ");
			}
		}
		
		private void cargar()
		{
			var consulta = from clientes in db.clientes select clientes;
			tabla.ItemsSource = consulta.ToList();
			
		
		}
		

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			Suma();
			CONTRATO();
			agregar();
			cargar();



		}

		private void limpiar_Click(object sender, RoutedEventArgs e)
		{
			Limpiar();
		}
		
		private void tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			object id = ((Button)sender).CommandParameter;
			if (id != null)
			{
				int i = int.Parse(id.ToString());

				db.ps_eliminar(i);
				cargar();
			}
			
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			object id = ((Button)sender).CommandParameter;
			if (id != null)
			{
				int i = int.Parse(id.ToString());
			   baseDatos.clientes clientes = (from cli in db.clientes
											  where cli.id == i
											  select cli).First();

				txt_ApellidoCliente.Text = clientes.apellido;
				txt_Email.Text = clientes.email;
				txt_NombreCliente.Text = clientes.nombre;
				txt_NROPersonas.Text = clientes.NroPersona.ToString();
				txt_Precio.Text = clientes.Total.ToString();
				txt_total.Text = clientes.Total.ToString();
			}

		}
	}
}
