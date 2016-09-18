﻿namespace ReactiveGit.Gui.WPF.Selectors
{
    using System.Windows;
    using System.Windows.Controls;

    using ReactiveGit.Gui.Base.ViewModel.Repository;

    /// <summary>
    /// Selects the appropriate data template.
    /// </summary>
    public class DockingElementTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Gets or sets the data template for branches.
        /// </summary>
        public DataTemplate Template { get; set; }

        /// <inheritdoc />
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IRepositoryDocumentViewModel)
            {
                return this.Template;
            }

            return base.SelectTemplate(item, container);
        }
    }
}