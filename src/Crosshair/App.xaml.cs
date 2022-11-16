using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace Crosshair
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Mutex? _mutex;

        public App()
        {
            _mutex = new Mutex(false, "Global\\" + Process.GetCurrentProcess().ProcessName, out var isFirst);
            if (!isFirst)
            {
                _mutex.Dispose();
                MessageBox.Show($"{Process.GetCurrentProcess().ProcessName} is running!");
                Environment.Exit(-1);
                return;
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _mutex?.Dispose();
            base.OnExit(e);
        }
    }
}