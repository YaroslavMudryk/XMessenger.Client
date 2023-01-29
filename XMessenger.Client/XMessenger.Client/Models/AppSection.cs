namespace XMessenger.Client.Models
{
    public class AppSection
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string IconDark { get; set; }
        public bool IsEnabled { get; set; }
        public bool NeedAuth { get; set; }
        public Type TargetType { get; set; }
    }
}