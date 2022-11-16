using System.Windows.Controls;

namespace Crosshair.Crosshairs.Dot
{
    public class Dot : ICrosshair
    {
        public Dot(DotViewModel dotViewModel)
        {
            Renderer = new DotRenderer(dotViewModel);
            Configuration = new DotConfiguration(dotViewModel);
        }

        public UserControl Renderer { get; }
        public UserControl Configuration { get; }
    }
}