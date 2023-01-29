namespace XMessenger.Client.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private List<AppSection> _tabs;

        public AppSection Profile { get; set; }
        public AppSection Groups { get; set; }
        public AppSection News { get; set; }
        public AppSection Messenger { get; set; }
        public AppSection Settings { get; set; }

        public ShellViewModel()
        {
            Profile = new AppSection() { Title = GetProfileTitle(), Icon = "profile_circle.png", IconDark = "profile_circle_dark.png", IsEnabled = true, NeedAuth = false, TargetType = typeof(ProfilePage) };
            Groups = new AppSection() { Title = AppResource.Groups, Icon = "groups.png", IconDark = "groups_dark.png", IsEnabled = true, NeedAuth = true, TargetType = typeof(ToBeSoonPage) };
            News = new AppSection() { Title = AppResource.News, Icon = "news.png", IconDark = "news_dark.png", IsEnabled = true, NeedAuth = true, TargetType = typeof(ToBeSoonPage) };
            Messenger = new AppSection() { Title = AppResource.Messenger, Icon = "chat.png", IconDark = "chat_dark.png", IsEnabled = true, NeedAuth = true, TargetType = typeof(ToBeSoonPage) };
            Settings = new AppSection() { Title = AppResource.Settings, Icon = "settings.png", IconDark = "settings_dark.png", IsEnabled = true, NeedAuth = false, TargetType = typeof(SettingsPage) };

            _tabs = new List<AppSection>
            {
                Profile,
                Groups,
                News,
                Messenger,
                Settings
            };

            CheckAvalibleTabs();
        }

        public void CheckAvalibleTabs()
        {
            if (!AppSettings.IsAuthenticated)
            {
                _tabs.Where(s => s.NeedAuth).ForEach(tab =>
                {
                    tab.IsEnabled = false;
                });
                return;
            }
            if (AppSettings.IsAuthenticated)
            {
                _tabs.Where(s => s.NeedAuth).ForEach(tab =>
                {
                    tab.IsEnabled = true;
                });
                return;
            }
        }

        private string GetProfileTitle()
        {
            if (!AppSettings.IsAuthenticated)
                return AppResource.Login;
            return AppSettings.User.FirstName;
        }
    }
}