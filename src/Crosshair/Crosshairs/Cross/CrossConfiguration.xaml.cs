using System.Windows.Controls;

namespace Crosshair.Crosshairs.Cross
{
    /// <summary>
    /// CrosshairConfiguration.xaml 的交互逻辑
    /// </summary>
    public partial class CrossConfiguration : UserControl
    {
        public CrossConfiguration(CrossViewModel crosshairViewModel)
        {
            InitializeComponent();
            DataContext = crosshairViewModel;
        }
    }
}