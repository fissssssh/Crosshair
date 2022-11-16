using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Windows.Media;

namespace Crosshair.Crosshairs.Dot
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class DotViewModel : ObservableObject
    {
        [ObservableProperty]
        [JsonProperty("enabled")]
        private bool _enabled = false;

        [ObservableProperty]
        [JsonProperty("size")]
        private int _size = 5;

        [ObservableProperty]
        [JsonProperty("color")]
        private Color _color = Colors.Red;
    }
}