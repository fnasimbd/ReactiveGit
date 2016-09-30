﻿namespace ReactiveGit.Gui.WPF
{
    using System;

    /// <summary>
    /// Interaction logic for MainWindow.
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>Initializes a new instance of the <see cref="MainWindow" /> class.</summary>
        public MainWindow()
        {
            this.InitializeComponent();

            this.Dispatcher.InvokeAsync(
                () =>
                    {
                        this.AppBootstrapper = new AppBootstrapper();
                        this.DataContext = this.AppBootstrapper;
                    });
        }

        /// <summary>
        /// Gets or sets the app bootstrapper.
        /// </summary>
        public AppBootstrapper AppBootstrapper { get; protected set; }

        /// <summary>The window_ closed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void Window_Closed(object sender, EventArgs e)
        {
            // TODO: Remove once avalonDock fixes the bug described here : http://stackoverflow.com/questions/37834945/unhandled-system-componentmodel-win32exception-when-using-avalondock-2-0
            Environment.Exit(0);
        }
    }
}