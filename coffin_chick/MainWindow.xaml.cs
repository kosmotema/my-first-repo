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

namespace CoffinChick {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			TrayIcon.Visibility = Visibility.Visible;
			Hide();
			MessageBox.Show("Удачной игры в ящик :)", "Добро пожаловать!", MessageBoxButton.OK,
				MessageBoxImage.Information);
		}

		private void MainWindow_OnStateChanged(object sender, EventArgs e) {
			if (WindowState == WindowState.Minimized) return;
			Hide();
			MessageBox.Show("Не стоит разворачивать окно, не надо", "Будь осторожней", MessageBoxButton.OK,
				MessageBoxImage.Warning);
		}

		private void TrayIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e) {
			MessageBox.Show("Хочешь закрыть окно? Нажми правой кнопкой мыши по значку!", "А зачем?",
				MessageBoxButton.OK,
				MessageBoxImage.Information);
		}

		private void TrayIcon_TrayRightMouseDown(object sender, RoutedEventArgs e) {
			if (MessageBox.Show("А ты точно хочешь выбраться из ящика?", "Не хочешь играть?", MessageBoxButton.YesNo,
				MessageBoxImage.Warning) == MessageBoxResult.Yes)
				Close();
		}
	}
}