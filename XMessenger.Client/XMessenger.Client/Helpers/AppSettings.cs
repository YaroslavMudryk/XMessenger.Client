using System.Text.Json;

namespace XMessenger.Client.Helpers
{
    public static class AppSettings
    {
        public static AppTheme Theme
        {
            get
            {
                if (!Preferences.ContainsKey(nameof(Theme)))
                    return AppTheme.Light;

                return Enum.Parse<AppTheme>(Preferences.Get(nameof(Theme), Enum.GetName(AppTheme.Light)));
            }
            set => Preferences.Set(nameof(Theme), value.ToString());
        }

        public static string Language
        {
            get => Preferences.Get(nameof(Language), "uk-UA");
            set => Preferences.Set(nameof(Language), value.ToString());
        }

        public static bool IsWifiOnlyEnabled
        {
            get => Preferences.Get(nameof(IsWifiOnlyEnabled), false);
            set => Preferences.Set(nameof(IsWifiOnlyEnabled), value);
        }

        public static bool IsAuthenticated
        {
            get => Preferences.Get(nameof(IsAuthenticated), false);
            set => Preferences.Set(nameof(IsAuthenticated), value);
        }

        public static AuthUser User
        {
            get => JsonSerializer.Deserialize<AuthUser>(Preferences.Get(nameof(User), "{}"));
            set => Preferences.Set(nameof(User), JsonSerializer.Serialize(value));
        }
    }
}
