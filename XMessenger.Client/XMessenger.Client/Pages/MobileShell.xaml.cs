using XMessenger.Client.ViewModels;

namespace XMessenger.Client.Pages;

public partial class MobileShell
{
	public MobileShell()
	{
		InitializeComponent();
        BindingContext = new ShellViewModel();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();


        if (!AppSettings.IsAuthenticated)
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(LoginPage));
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}