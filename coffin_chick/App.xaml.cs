using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;

namespace CoffinChick {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {

		public App() {
			InitializeComponent();

			((TaskbarIcon) Resources["TrayIcon"]).Visibility = Visibility.Visible;

			MessageBox.Show(@"Удачной игры в ящик :)
Чтобы вылезти из ящика, нажми на значок в трее", @"Добро пожаловать!", MessageBoxButton.OK,
				MessageBoxImage.Information);
		}

		private void TrayIcon_TrayMouseDown(object sender, RoutedEventArgs e) {
			if (MessageBox.Show(@"А ты точно хочешь выбраться из ящика?", @"Надоело играть?", MessageBoxButton.YesNo,
				MessageBoxImage.Warning) == MessageBoxResult.Yes)
				Shutdown();
		}
	}
}