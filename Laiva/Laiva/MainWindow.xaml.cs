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
using System.Threading;

namespace Laiva {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			Koordinaatit.xx = 3;
			Koordinaatit.yy = 3;
			textBlockx.Text = String.Format("" + Koordinaatit.xx);
			
			

		}

		private void Window_KeyDown(object sender, KeyEventArgs e) {
			Koordinaatit.yy = 2;
			Koordinaatit.xx = 2;
			switch (e.Key) {
				case Key.W:
					int numero1 = int.Parse(textBlocky.Text);
					numero1--;
					Console.Beep(4000,100);
					if (numero1 == 2) {
						Console.Beep(2000, 100);
					}
					textBlocky.Text = String.Format("" + numero1);
					break;
				case Key.S:
					int numero2 = int.Parse(textBlocky.Text);
					numero2++;
					Console.Beep(4000, 100);
					textBlocky.Text = String.Format("" + numero2);
					break;
				case Key.D:
					int numero3 = int.Parse(textBlockx.Text);
					numero3++;
					textBlockx.Text = String.Format("" + numero3);
					Console.Beep(4000, 100);
					break;
				case Key.A:
					int numero4 = int.Parse(textBlockx.Text);
					numero4--;
					textBlockx.Text = String.Format("" + numero4);
					Console.Beep(4000, 100);
					break;
				default:
					break;
			}
			
		}
	}

	public class Koordinaatit {
		public static int xx { get; set; }
		public static int yy { get; set; }
	}
}
