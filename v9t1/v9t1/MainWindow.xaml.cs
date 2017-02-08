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

namespace v9t1 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void lisaaAuto(object sender, RoutedEventArgs e) {
			string teksti = tAuto.Text;
			int luku = int.Parse(teksti);
			luku++;
			tAuto.Text = String.Format("" +luku);
		}
		private void lisaaRekka(object sender, RoutedEventArgs e) {
			string teksti = tRekka.Text;
			int luku = int.Parse(teksti);
			luku++;
			tRekka.Text = String.Format("" + luku);
		}
	}
}
