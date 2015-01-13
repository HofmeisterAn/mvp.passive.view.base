using Mvp.Passive.View.Base.Model.IRepository;
using Mvp.Passive.View.Base.Main.Engine;
using Mvp.Passive.View.Base.Main.View.Application;

namespace Mvp.Passive.View.Base.Main.Presenter
{
    /// <summary>
    /// Aacts upon the model and the view. Retrieves data from repositories and formats it to display the information in the view. Is associated to <seealso cref="IApplicationRepository"/> and <seealso cref="ApplicationView"/>.
    /// This implementation uses a background worker queue to execute intensive tasks and is not blocking the UI.
    /// </summary>
    public class ApplicationPresenter
    {
        private readonly IApplicationView view;

        private readonly IApplicationRepository repository;

        private readonly BackgroundQueue worker = new BackgroundQueue();

        public bool IsIdle { get { return this.worker.IsIdle; } }

        public ApplicationPresenter(IApplicationView view, IApplicationRepository repository)
        {
            this.view = view;
            this.view.Presenter = this;

            this.repository = repository;

            worker.QueueTask(this.Initialize);
        }

        private void Initialize()
        {
            var user = this.repository.User.FindById(1);

            if (user == null) return;

            this.view.FirstName = user.FirstName;
            this.view.Surname = user.Surname;
            this.view.GroupCount = user.Groups.Count;
        }
    }
}
