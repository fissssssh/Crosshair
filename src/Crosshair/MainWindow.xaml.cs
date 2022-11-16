using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace Crosshair
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AllowsTransparency = true;
            WindowStyle = WindowStyle.None;
            ResizeMode = ResizeMode.NoResize;
            Background = new SolidColorBrush(Colors.Transparent);
            ShowInTaskbar = false;
            Width = SystemParameters.PrimaryScreenWidth;
            Height = SystemParameters.PrimaryScreenHeight;
            WindowStartupLocation = WindowStartupLocation.Manual;
            Left = 0;
            Top = 0;
            Topmost = true;

            var mainViewModel = new MainWindowViewModel();
            DataContext = mainViewModel;

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            var handle = new WindowInteropHelper(this).Handle;

            // Set window transparent and penetrate
            var dwExFlags = GetWindowLong(handle, GWL_EXSTYLE) | WS_EX_TRANSPARENT;
            SetWindowLong(handle, GWL_EXSTYLE, dwExFlags);
        }

        #region Win32 API

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern long GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);

        #endregion Win32 API
    }
}