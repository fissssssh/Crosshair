using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Windows.Media;

namespace Crosshair.Crosshairs.Cross
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class CrossViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(LeftY1))]
        [NotifyPropertyChangedFor(nameof(LeftY2))]
        [NotifyPropertyChangedFor(nameof(TopX1))]
        [NotifyPropertyChangedFor(nameof(TopX2))]
        [NotifyPropertyChangedFor(nameof(RightX1))]
        [NotifyPropertyChangedFor(nameof(RightY1))]
        [NotifyPropertyChangedFor(nameof(RightX2))]
        [NotifyPropertyChangedFor(nameof(RightY2))]
        [NotifyPropertyChangedFor(nameof(BottomX1))]
        [NotifyPropertyChangedFor(nameof(BottomY1))]
        [NotifyPropertyChangedFor(nameof(BottomX2))]
        [NotifyPropertyChangedFor(nameof(BottomY2))]
        [JsonProperty("diffusion")]
        private int _diffusion = 5;

        [ObservableProperty]
        [JsonProperty("thickness")]
        private int _thickness = 1;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(LeftY1))]
        [NotifyPropertyChangedFor(nameof(LeftX2))]
        [NotifyPropertyChangedFor(nameof(LeftY2))]
        [NotifyPropertyChangedFor(nameof(TopX1))]
        [NotifyPropertyChangedFor(nameof(TopX2))]
        [NotifyPropertyChangedFor(nameof(TopY2))]
        [NotifyPropertyChangedFor(nameof(RightX1))]
        [NotifyPropertyChangedFor(nameof(RightY1))]
        [NotifyPropertyChangedFor(nameof(RightX2))]
        [NotifyPropertyChangedFor(nameof(RightY2))]
        [NotifyPropertyChangedFor(nameof(BottomX1))]
        [NotifyPropertyChangedFor(nameof(BottomY1))]
        [NotifyPropertyChangedFor(nameof(BottomX2))]
        [NotifyPropertyChangedFor(nameof(BottomY2))]
        [JsonProperty("length")]
        private int _length = 20;

        [ObservableProperty]
        [JsonProperty("enabled")]
        private bool _enabled = true;

        [ObservableProperty]
        [JsonProperty("color")]
        private Color _color = Colors.Red;

        public int LeftX1 => 0;
        public int LeftY1 => _diffusion + _length;
        public int LeftX2 => _length;
        public int LeftY2 => _diffusion + _length;

        public int TopX1 => _diffusion + _length;
        public int TopY1 => 0;
        public int TopX2 => _diffusion + _length;
        public int TopY2 => _length;

        public int RightX1 => _length + 2 * _diffusion;
        public int RightY1 => _diffusion + _length;
        public int RightX2 => 2 * (_length + _diffusion);
        public int RightY2 => _diffusion + _length;

        public int BottomX1 => _diffusion + _length;
        public int BottomY1 => _length + 2 * _diffusion;
        public int BottomX2 => _diffusion + _length;
        public int BottomY2 => 2 * (_length + _diffusion);
    }
}