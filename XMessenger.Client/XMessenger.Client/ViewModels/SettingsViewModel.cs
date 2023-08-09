namespace XMessenger.Client.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        private LocalizationResourceManager LocalizationResource => LocalizationResourceManager.Instance;

        private List<SettingModel> _languages;
        private List<SettingModel> _themes;

        public SettingModel SelectedTheme
        {
            set
            {
                if (value.Value == "default")
                {
                    AppSettings.Theme = App.Current.PlatformAppTheme;
                }
                if (Enum.TryParse<AppTheme>(value.Value, out AppTheme theme))
                {
                    AppSettings.Theme = theme;
                }
                DeviceHelper.SetDeviceTheme();
            }
        }

        public SettingModel SelectedLanguage
        {
            set
            {
                if (_languages.Select(s => s.Value).Contains(value.Value))
                {
                    AppSettings.Language = value.Value;
                    var cult = new CultureInfo(value.Value);
                    LocalizationResource.SetCulture(cult);
                    CultureInfo.DefaultThreadCurrentCulture = cult;
                    CultureInfo.DefaultThreadCurrentUICulture = cult;
                }
            }
        }

        public List<SettingModel> Themes => _themes;
        public List<SettingModel> Languages => _languages;

        [ObservableProperty]
        bool isWifiOnlyEnabled;

        partial void OnIsWifiOnlyEnabledChanged(bool value) =>
            AppSettings.IsWifiOnlyEnabled = value;

        public string AppVersion => AppInfo.VersionString;

        public SettingsViewModel()
        {
            isWifiOnlyEnabled = AppSettings.IsWifiOnlyEnabled;

            _languages = new List<SettingModel>
            {
                new SettingModel
                {
                    Title = LocalizationResource["Lang_En"].ToString(),
                    Value = "en-US"
                },
                new SettingModel
                {
                    Title = LocalizationResource["Lang_Uk"].ToString(),
                    Value = "uk-UA"
                },
            };

            _themes = new List<SettingModel>
            {
                new SettingModel
                {
                    Title = LocalizationResource["Theme_Follow_System"].ToString(),
                    Value = "default"
                },
                new SettingModel
                {
                    Title = LocalizationResource["Dark_Mode"].ToString(),
                    Value = AppTheme.Dark.ToString()
                },
                new SettingModel
                {
                    Title = LocalizationResource["Light_Mode"].ToString(),
                    Value = AppTheme.Light.ToString()
                }
            };
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
