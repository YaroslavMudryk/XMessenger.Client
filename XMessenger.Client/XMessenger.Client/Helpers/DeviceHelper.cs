namespace XMessenger.Client.Helpers
{
    public static class DeviceHelper
    {
        private static DevicePlatform[] _mobilePlatforms = new DevicePlatform[]
        {
            DevicePlatform.Android,
            DevicePlatform.iOS,
            DevicePlatform.Tizen,
            DevicePlatform.watchOS,
        };

        private static DevicePlatform[] _desktopPlatforms = new DevicePlatform[]
        {
            DevicePlatform.WinUI,
            DevicePlatform.MacCatalyst,
            DevicePlatform.macOS,
            DevicePlatform.tvOS,
            DevicePlatform.Unknown
        };

        public static bool IsMobile()
        {
            var deviceInfo = DeviceInfo.Current;
            return _mobilePlatforms.Contains(deviceInfo.Platform);
        }

        public static bool IsDesktop()
        {
            var deviceInfo = DeviceInfo.Current;
            return _desktopPlatforms.Contains(deviceInfo.Platform);
        }

        public static void SetDeviceTheme()
        {
            switch (AppSettings.Theme)
            {
                default:
                case AppTheme.Light:
                    App.Current.UserAppTheme = AppTheme.Light;
                    break;
                case AppTheme.Dark:
                    App.Current.UserAppTheme = AppTheme.Dark;
                    break;

            }
        }
    }
}