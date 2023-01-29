using XMessenger.Client.ViewModels;

namespace XMessenger.Client.Pages;

public partial class DesktopShell
{
	public DesktopShell()
	{
		InitializeComponent();
        BindingContext = new ShellViewModel();
    }
}