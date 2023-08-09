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
                    Link = "https://api.xmessenger.com/auth/google"
                },
                new SocialLink
                {
                    Id = "2",
                    ImageSource = "microsoft.svg",
                    Name = "Microsoft",
                    Link = "https://api.xmessenger.com/auth/microsoft"
                },
                new SocialLink
                {
                    Id = "3",
                    ImageSource = "facebook.svg",
                    Name = "Facebook",
                    Link = "https://api.xmessenger.com/auth/facebook"
                },
                new SocialLink
                {
                    Id = "4",
                    ImageSource = "github.svg",
                    Name = "GitHub",
                    Link = "https://api.xmessenger.com/auth/github"
                },
            };

            IsVisibleOtherSocials = SocialLinks.Any();
        }
    }
}
