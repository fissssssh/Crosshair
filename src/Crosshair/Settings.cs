using CommunityToolkit.Mvvm.ComponentModel;
using Crosshair.Crosshairs.Cross;
using Crosshair.Crosshairs.Dot;
using Crosshair.Crosshairs.InvertedTriangle;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Crosshair
{
    [JsonObject(MemberSerialization.OptIn)]
    public sealed partial class Settings : ObservableObject
    {
        private static readonly string _settingsFilePath = Environment.ExpandEnvironmentVariables(Path.Join("%userprofile%", ".crosshair", "settings.json"));

        [ObservableProperty]
        [JsonProperty("enabled")]
        private bool _enabled = true;

        [ObservableProperty]
        [JsonProperty("dot")]
        public DotViewModel _dot = new();

        [ObservableProperty]
        [JsonProperty("crosshair")]
        public CrossViewModel _crosshair = new();

        [ObservableProperty]
        [JsonProperty("invertedTriangle")]
        public InvertedTriangleViewModel _invertedTriangle = new();

        public static Settings ReadSettings()
        {
            if (!File.Exists(_settingsFilePath))
            {
                return new Settings();
            }
            try
            {
                var text = File.ReadAllText(_settingsFilePath);
                return JsonConvert.DeserializeObject<Settings>(text)!;
            }
            catch (Exception)
            {
                return new Settings();
            }
        }

        public async Task WriteSettingsAsync()
        {
            var dir = Path.GetDirectoryName(_settingsFilePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir!);
            }
            await File.WriteAllTextAsync(_settingsFilePath, JsonConvert.SerializeObject(this));
        }
    }
}