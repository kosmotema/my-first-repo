using System;
using System.Windows;

namespace CoffinChick {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			TrayIcon.Visibility = Visibility.Visible;
			Hide();
			MessageBox.Show(@"Удачной игры в ящик :)
Чтобы вылезти из ящика, нажми на значок в трее", @"Добро пожаловать!", MessageBoxButton.OK,
				MessageBoxImage.Information);
		}

		private void MainWindow_OnStateChanged(object sender, EventArgs e) {
			if (WindowState == WindowState.Minimized) return;
			Hide();
			MessageBox.Show(@"Не стоит разворачивать окно, не надо", @"Будь осторожней", MessageBoxButton.OK,
				MessageBoxImage.Warning);
		}

		private void TrayIcon_TrayMouseDown(object sender, RoutedEventArgs e) {
			if (MessageBox.Show(@"А ты точно хочешь выбраться из ящика?", @"Надоело играть?", MessageBoxButton.YesNo,
				MessageBoxImage.Warning) == MessageBoxResult.Yes)
				Close();
		}
	}
}