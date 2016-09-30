namespace ReactiveGit.Gui.Core.ViewModel.Content
{
    using System.ComponentModel;

    /// <summary>
    /// A view model that is used as content in the view layer.
    /// </summary>
    public interface IContentViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the content id of the content.
        /// </summary>
        string ContentId { get; }

        /// <summary>
        /// Gets the name of the document view model.
        /// </summary>
        string FriendlyName { get; }
    }
}