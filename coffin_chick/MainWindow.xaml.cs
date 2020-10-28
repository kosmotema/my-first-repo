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

namespace Ящик
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() {
			InitializeComponent();
		}

		private void MainWindow_OnStateChanged(object sender, EventArgs e) {
			if (WindowState != WindowState.Minimized) return;
			TrayIcon.Visibility = Visibility.Visible;
			//ShowInTaskbar = true;
			Hide();
		}

		private void TrayIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)
		{
			Show();
			WindowState = WindowState.Normal;
			TrayIcon.Visibility = Visibility.Hidden;
		}
	}
}
