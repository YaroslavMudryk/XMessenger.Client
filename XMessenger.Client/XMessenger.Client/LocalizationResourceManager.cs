using Microsoft.Maui.Controls;

namespace XMessenger.Client
{
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        public LocalizationResourceManager()
        {
            LangResource.Culture = CultureInfo.CurrentCulture;
        }

        public static LocalizationResourceManager Instance => new();

        public object this[string resourceKey]
            => LangResource.ResourceManager.GetObject(resourceKey, LangResource.Culture) ?? Array.Empty<byte>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetCulture(CultureInfo culture)
        {
            LangResource.Culture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
