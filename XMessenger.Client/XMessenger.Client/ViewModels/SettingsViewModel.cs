using XMessenger.Client.Extensions;

namespace XMessenger.Client.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        bool isDarkModeEnabled;

        [ObservableProperty]
        bool isWifiOnlyEnabled;

        partial void OnIsDarkModeEnabledChanged(bool value) =>
            ChangeUserAppTheme(value);
        partial void OnIsWifiOnlyEnabledChanged(bool value) =>
            AppSettings.IsWifiOnlyEnabled = value;

        public string AppVersion => AppInfo.VersionString;

        public SettingsViewModel()
        {
            isDarkModeEnabled = AppSettings.Theme == AppTheme.Dark;
            isWifiOnlyEnabled = AppSettings.IsWifiOnlyEnabled;
        }

        void ChangeUserAppTheme(bool activateDarkMode)
        {
            AppSettings.Theme = activateDarkMode
                ? AppTheme.Dark
                : AppTheme.Light;

            DeviceHelper.SetDeviceTheme();
        }
    }
}
