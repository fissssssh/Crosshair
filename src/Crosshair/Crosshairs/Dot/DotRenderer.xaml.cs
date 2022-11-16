using System.Windows.Controls;

namespace Crosshair.Crosshairs.Dot
{
    /// <summary>
    /// DotRenderer.xaml 的交互逻辑
    /// </summary>
    public partial class DotRenderer : UserControl
    {
        public DotRenderer(DotViewModel dotViewModel)
        {
            InitializeComponent();
            DataContext = dotViewModel;
        }
    }
}