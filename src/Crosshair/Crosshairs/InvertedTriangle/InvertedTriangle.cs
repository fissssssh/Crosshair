using System.Windows.Controls;

namespace Crosshair.Crosshairs.InvertedTriangle
{
    public class InvertedTriangle : ICrosshair
    {
        public InvertedTriangle(InvertedTriangleViewModel invertedTriangleViewModel)
        {
            Renderer = new InvertedTriangleRenderer() { DataContext = invertedTriangleViewModel };
            Configuration = new InvertedTriangleConfiguration() { DataContext = invertedTriangleViewModel };
        }

        public UserControl Renderer { get; }

        public UserControl Configuration { get; }
    }
}