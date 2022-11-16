using System.Windows.Controls;

namespace Crosshair.Crosshairs.Dot
{
    /// <summary>
    /// DotConfiguration.xaml 的交互逻辑
    /// </summary>
    public partial class DotConfiguration : UserControl
    {
        public DotConfiguration(DotViewModel dotViewModel)
        {
            InitializeComponent();
            DataContext = dotViewModel;
        }
    }
}