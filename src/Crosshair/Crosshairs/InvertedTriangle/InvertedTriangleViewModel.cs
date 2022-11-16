using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Media;
using static System.Math;

namespace Crosshair.Crosshairs.InvertedTriangle
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class InvertedTriangleViewModel : ObservableObject
    {
        private int _length = 5;
        private int _thickness = 1;
        private int _angle = 90;

        [ObservableProperty]
        [JsonProperty("enabled")]
        private bool _enabled = false;

        [ObservableProperty]
        [JsonProperty("color")]
        private Color _color = Colors.Red;

        public Point P1 { get; private set; }
        public Point P2 { get; private set; }
        public Point P3 { get; private set; }
        public Point P4 { get; private set; }
        public Point P5 { get; private set; }
        public Point P6 { get; private set; }

        public double Radians => PI * _angle / 180;

        [JsonProperty("length")]
        public int Length
        {
            get => _length; set
            {
                SetProperty(ref _length, value);
                CalculatePoints();
            }
        }

        [JsonProperty("thickness")]
        public int Thickness
        {
            get => _thickness; set
            {
                SetProperty(ref _thickness, value);
                CalculatePoints();
            }
        }

        [JsonProperty("angle")]
        public int Angle
        {
            get => _angle; set
            {
                SetProperty(ref _angle, value);
                CalculatePoints();
            }
        }

        private void CalculatePoints()
        {
            var radians = (_angle / 180d * PI) / 2;

            var x = _length * Sin(radians);
            var y = _length * Cos(radians);

            P1 = new Point(x, y + _thickness);
            P2 = new Point(0, 2 * y + _thickness);
            P3 = new Point(0, 2 * (y + _thickness));
            P4 = new Point(x, y + 2 * _thickness);
            P5 = new Point(2 * x, 2 * (y + _thickness));
            P6 = new Point(2 * x, 2 * y + _thickness);

            OnPropertyChanged(nameof(P1));
            OnPropertyChanged(nameof(P2));
            OnPropertyChanged(nameof(P3));
            OnPropertyChanged(nameof(P4));
            OnPropertyChanged(nameof(P5));
            OnPropertyChanged(nameof(P6));
        }
    }
}