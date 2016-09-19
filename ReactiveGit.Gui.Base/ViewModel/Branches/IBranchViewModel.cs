﻿namespace ReactiveGit.Gui.Base.ViewModel.Branches
{
    using System.Collections.Generic;
    using System.Windows.Input;

    using ReactiveGit.Gui.Base.Model.Branches;
    using ReactiveGit.Model;

    /// <summary>
    /// View model associated with branches.
    /// </summary>
    public interface IBranchViewModel : IChildRepositoryDocumentViewModel
    {
        /// <summary>
        /// Gets a list of branches on the repository.
        /// </summary>
        IEnumerable<BranchNode> Branches { get; }

        /// <summary>
        /// Gets a command which will change the current branch.
        /// </summary>
        ICommand CheckoutBranch { get; }
    }
}