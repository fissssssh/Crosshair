using System.Windows.Controls;

namespace Crosshair.Crosshairs.Cross
{
    public class Cross : ICrosshair
    {
        public Cross(CrossViewModel crossViewModel)
        {
            Renderer = new CrossRenderer(crossViewModel);
            Configuration = new CrossConfiguration(crossViewModel);
        }

        public UserControl Renderer { get; }

        public UserControl Configuration { get; }
    }
}