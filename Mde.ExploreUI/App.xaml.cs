namespace Mde.ExploreUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//force light mode
		UserAppTheme = AppTheme.Light;

        MainPage = new AppShell();
	}
}
