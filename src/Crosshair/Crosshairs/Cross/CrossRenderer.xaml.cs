using System.Windows.Controls;

namespace Crosshair.Crosshairs.Cross
{
    /// <summary>
    /// CrosshairRenderer.xaml 的交互逻辑
    /// </summary>
    public partial class CrossRenderer : UserControl
    {
        public CrossRenderer(CrossViewModel crosshairViewModel)
        {
            InitializeComponent();
            DataContext = crosshairViewModel;
        }
    }
}