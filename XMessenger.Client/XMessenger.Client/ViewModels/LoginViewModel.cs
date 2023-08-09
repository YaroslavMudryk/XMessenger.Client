namespace XMessenger.Client.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private LocalizationResourceManager LocalizationResource => LocalizationResourceManager.Instance;
        public IList<SocialLink> SocialLinks { get; set; }
        public int ChunkSize { get; } = 3;
        public bool IsVisibleOtherSocials { get; set; }

        public LoginViewModel()
        {
            SocialLinks = new List<SocialLink>
            {
                new SocialLink
                {
                    Id = "1",
                    ImageSource = "google.svg",
                    Name = "Google",
                    Link = "https://api.xmessenger.com/auth/google",
                    IsAvailable = false
                },
                new SocialLink
                {
                    Id = "2",
                    ImageSource = "microsoft.svg",
                    Name = "Microsoft",
                    Link = "https://api.xmessenger.com/auth/microsoft",
                    IsAvailable = false
                },
                new SocialLink
                {
                    Id = "3",
                    ImageSource = "facebook.svg",
                    Name = "Facebook",
                    Link = "https://api.xmessenger.com/auth/facebook",
                    IsAvailable = false
                },
                new SocialLink
                {
                    Id = "4",
                    ImageSource = "github.svg",
                    Name = "GitHub",
                    Link = "https://api.xmessenger.com/auth/github",
                    IsAvailable = false
                },
            };

            IsVisibleOtherSocials = SocialLinks.Any();
        }
    }
}
