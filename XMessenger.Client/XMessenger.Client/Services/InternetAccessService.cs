namespace XMessenger.Client.Services
{
    public class InternetAccessService
    {
        private IConnectivity _current;

        public InternetAccessService(IConnectivity connectivity)
        {
            _current = connectivity;
        }

        public async Task<bool> HasWiFiConnectionAsync()
        {
            if (_current.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Not internet", "Check your connection", "close");
            }
            else
            {
                var profiles = Connectivity.ConnectionProfiles;
                var hasWifi = profiles.Contains(ConnectionProfile.WiFi);

                if (!AppSettings.IsWifiOnlyEnabled || hasWifi)
                {
                    return true;
                }
                else
                {
                    await Shell.Current.DisplayAlert("You need wifi", "Go to Settings to desactivate this option", "close");
                }
            }
            return false;
        }

        public bool IsConnectedToInternet()
        {
            return _current.NetworkAccess == NetworkAccess.Internet;
        }
    }
}
