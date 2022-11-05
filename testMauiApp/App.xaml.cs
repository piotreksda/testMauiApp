namespace testMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Console.WriteLine("Started the app");
        Application.Current.RequestedThemeChanged += (s, a) =>
        {
            Console.WriteLine("Theme changed");
        };
        MainPage = new AppShell();
	}
}

