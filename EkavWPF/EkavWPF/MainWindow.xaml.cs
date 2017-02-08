using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EkavWPF {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Mun_Functio(object sender, RoutedEventArgs e) {
			infoTextBlock.Text = "Tamahan jopa toimii! :D";
		}
		void DataWindow_Closing(object sender, CancelEventArgs e) {
			string teksti = infoTextBlock.Text;
			if (teksti == "okei") {
				e.Cancel = false;
			}
			else {
				e.Cancel = true;
				infoTextBlock.Text = "En sulkeudu";
			}
		}
		void Tapa(object sender, RoutedEventArgs e) {
			infoTextBlock.Text = "okei";
			Close();
		}
	}
}
