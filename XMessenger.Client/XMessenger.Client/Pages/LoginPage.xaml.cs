using XMessenger.Client.ViewModels;

namespace XMessenger.Client.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();

        BindingContext = loginViewModel;
    }

    public LoginPage()
    {
        InitializeComponent();

        BindingContext = new LoginViewModel();
    }
}