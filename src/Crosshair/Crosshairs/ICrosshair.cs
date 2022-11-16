using System.Windows.Controls;

namespace Crosshair.Crosshairs
{
    internal interface ICrosshair
    {
        UserControl Renderer { get; }
        UserControl Configuration { get; }
    }
}