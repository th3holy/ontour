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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vistas
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (Nombre.Text == "admin" && password.Text == "admin")
			{
				MessageBox.Show("Usuario y Contraseña Correctos", "Correcto", MessageBoxButton.OK, MessageBoxImage.Information);
				ventas ven = new ventas();
				ven.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usuario y Contraseña No Son Correctos", "Incorrecto", MessageBoxButton.OK, MessageBoxImage.Warning);
				

			}
		}
	}
}
