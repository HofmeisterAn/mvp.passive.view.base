using Mvp.Passive.View.Base.Model.IRepository;
using Mvp.Passive.View.Base.Main.Engine;
using Mvp.Passive.View.Base.Main.View.Application;

namespace Mvp.Passive.View.Base.Main.Presenter
{
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
