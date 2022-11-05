namespace testMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Console.WriteLine("Started the app");
        //this is commit and push to origin/dev
        Application.Current.RequestedThemeChanged += (s, a) =>
        {
            Console.WriteLine("Why there is no logs when change theme on macOS :( ");
        };
        MainPage = new AppShell();
        //this is commit and push to main
	}
}

