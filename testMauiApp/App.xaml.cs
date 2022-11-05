namespace testMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Console.WriteLine("Started the app");
        Application.Current.RequestedThemeChanged += (s, a) =>
        {
            Console.WriteLine("Why there is no logs when change theme on macOS :( ");
        };
        MainPage = new AppShell();
	}
}

