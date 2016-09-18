﻿namespace ReactiveGit.Gui.WPF
{
    using System.Windows;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for App.
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            this.DispatcherUnhandledException += this.AppGlobalDispatcherUnhandledException;
        }

        private void AppGlobalDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // TODO: Remove once AvalonDock fixes bug with SUCCESS exception.
            // See: http://stackoverflow.com/questions/37834945/unhandled-system-componentmodel-win32exception-when-using-avalondock-2-0
            e.Handled = true;
        }
    }
}