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

namespace NberekTablazat
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Nber> lista = new List<Nber>();
		public MainWindow()
		{
			InitializeComponent();

			lista.Add(new Nber("Vella Nándor", 42));
			lista.Add(new Nber("Lakatos Béla", 17));
			lista.Add(new Nber("Kovács Ferenc", 56));

			nberek.ItemsSource = lista;
		}

		private void Button_HozzáAd_Click(object sender, RoutedEventArgs e)
		{
			string name = TBName.Text;
			int age = Convert.ToInt32(TBAge.Text);

			if (age > 0 && age < 200 && !(name.Equals(null)) && !(age.Equals(null)))
			{
				MessageBoxResult choose = MessageBox.Show(name + "+" + age, "Biztos?", MessageBoxButton.YesNo);
				if (choose == MessageBoxResult.Yes)
				{
					Nber nber = new Nber(name, age);
					lista.Add(nber);
					nberek.Items.Refresh();
				}
			}
			else
			{
				MessageBox.Show("Hibás adatok!!!!", "Error");
			}
		}
	}
}
