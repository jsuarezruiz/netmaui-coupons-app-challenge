using CouponsApp.Views;

namespace CouponsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CouponsView();
	}
}