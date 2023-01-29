using XMessenger.Client.ViewModels;

namespace XMessenger.Client.Pages;

public partial class MobileShell
{
	public MobileShell()
	{
		InitializeComponent();
        BindingContext = new ShellViewModel();
    }
}