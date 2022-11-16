using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Crosshair.Crosshairs.Cross;
using Crosshair.Crosshairs.Dot;
using Crosshair.Crosshairs.InvertedTriangle;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Crosshair
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            _settings = Settings.ReadSettings();
            _dot = new(_settings.Dot);
            _cross = new(_settings.Crosshair);
            _invertedTriangle = new(_settings.InvertedTriangle);
        }

        [ObservableProperty]
        private Dot _dot;

        [ObservableProperty]
        private Cross _cross;

        [ObservableProperty]
        private InvertedTriangle _invertedTriangle;

        [ObservableProperty]
        private Settings _settings;

        [RelayCommand]
        public void Exit()
        {
            Environment.Exit(0);
        }

        [RelayCommand]
        public async Task Configuration()
        {
            var dialog = new ConfigurationWindow()
            {
                DataContext = this,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            dialog.ShowDialog();
            await _settings.WriteSettingsAsync();
        }
    }
}