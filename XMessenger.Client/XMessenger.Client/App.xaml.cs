namespace XMessenger.Client;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        InitUser();

        DeviceHelper.SetDeviceTheme();

        DeviceHelper.SetDeviceLanguage();

        if (DeviceHelper.IsMobile())
            MainPage = new MobileShell();
        if (DeviceHelper.IsDesktop())
            MainPage = new DesktopShell();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
    }

    Window window;
    protected override Window CreateWindow(IActivationState activationState)
    {
        window = base.CreateWindow(activationState);

        if (DeviceHelper.IsDesktop())
        {
            window.MinimumWidth = 1080;
            window.MaximumWidth = 1920;
            window.MinimumHeight = 500;
            window.MaximumHeight = 1080;

            window.SizeChanged += Window_SizeChanged;
        }

        return window;
    }

    private void Window_SizeChanged(object sender, EventArgs e)
    {
        if (window is null)
            return;

        if (window.Width < 1200)
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        else
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Locked;
    }

    private void InitUser()
    {
        AppSettings.IsAuthenticated = true;
        AppSettings.User = new AuthUser
        {
            Id = 1,
            FirstName = "Mike",
            LastName = "Kostenko",
            Fullname = "Mike Kostenko"
        };
    }
}